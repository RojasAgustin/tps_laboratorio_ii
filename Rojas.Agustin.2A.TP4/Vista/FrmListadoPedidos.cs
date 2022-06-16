using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmListadoPedidos : Form
    {
        private Listado listado;
        private Listado databaseListado;
        private double ganancias;
        private ClienteDAO dao;
        private string codigoDescuento;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="ganancias"></param>
        public FrmListadoPedidos(Listado listado, double ganancias)
        {
            InitializeComponent();
            this.listado = listado;
            this.databaseListado = new Listado();
            this.ganancias = ganancias;
            dao = new ClienteDAO();
            this.Load += new EventHandler(this.InicializarControles);
        }

        /// <summary>
        /// Propiedad de solo lectura del atributo ganancias
        /// </summary>
        public double Ganancias
        {
            get
            {
                return this.ganancias;
            }
        }

        /// <summary>
        /// Inicializa todos los controles 
        /// y añade los botones de la database si la conexion
        /// es exitosa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InicializarControles(object sender,EventArgs e)
        {
            //Listado
            this.dgListado.DataSource = this.listado.ListaClientes;

            //Criterios de ordenamiento
            this.cboOrdenar.Items.Add("NOMBRE");
            this.cboOrdenar.Items.Add("PRECIO");
            this.cboOrdenar.Items.Add("CODIGO");
            this.cboOrdenar.SelectedItem = "CODIGO";

            //label Ganancias
            this.lblGanancias.Text = this.ganancias.ToString();

            //Botones DB
            try
            {
                if (ClienteDAOExtension.VerificarConexion(dao, ".", "TP_04"))
                {
                    this.btnBorrarCliente.Visible = true;
                    this.btnGuardarDB.Visible = true;
                    this.btnLeerDB.Visible = true;
                    this.btnModificarCliente.Visible = true;
                    this.databaseListado.ListaClientes = dao.LeerBaseDeDatos();
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }


        }

        /// <summary>
        /// Actualiza el data grid para que se 
        /// reflejen los cambios
        /// </summary>
        private void RefrescarDataGrid()
        {
            this.dgListado.DataSource = null;
            this.dgListado.DataSource = this.listado.ListaClientes;
            this.lblGanancias.Text = this.ganancias.ToString();
            this.databaseListado.ListaClientes = dao.LeerBaseDeDatos();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Ordena el listado segun el criterio elegido
        /// en el combo box y actualiza el data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenar.SelectedItem.ToString())
            {
                case "NOMBRE":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorNombre);
                    break;
                case "PRECIO":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorPrecio);
                    break;
                case "CODIGO":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorCodigo);
                    break;
            }
            this.RefrescarDataGrid();
        }

        /// <summary>
        /// Muestra la informacion del pedido seleccionado
        /// en un MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgListado.RowCount != 0)
                {
                    MessageBox.Show(dgListado.SelectedRows[0].DataBoundItem.ToString(), "Zoom", MessageBoxButtons.OK);
                }
                else
                {
                    throw new LibreriaVaciaException("El listado de pedidos de clientes esta vacio",null);
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Elimina al pedido del listado y añade
        /// el precio de la venta a las ganancias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgListado.RowCount != 0)
                {
                    Cliente cliente = (Cliente)this.dgListado.SelectedRows[0].DataBoundItem;
                    this.InformarVentaExitosa(cliente);
                    this.listado -= cliente;
                    this.ganancias += (int)cliente.PrecioCompra;
                    this.RefrescarDataGrid();                    
                }
                else
                {
                    throw new LibreriaVaciaException("El listado de pedidos de clientes esta vacio", null);
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Muestra un message box con el error
        /// </summary>
        /// <param name="ex"></param>
        private void MostrarVentanaDeError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Trae el listado de clientes de la base de datos
        /// y actualiza el data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLeerDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta seguro de querer traer el listado de la base de datos? Se sobrescribira el actual",
                    "Leer Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.listado.ListaClientes = await this.CargarBaseDeDatos();
                    this.RefrescarDataGrid();
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Ejecuta un hilo secundario que simula esperar por 2 segundos
        /// a leer desde la database y llama al metodo que cumple esta tarea
        /// </summary>
        /// <returns></returns>
        private async Task<List<Cliente>> CargarBaseDeDatos()
        {
            this.dbStatus.Visible = true;
            this.toolStripStatusDB.Text = "Cargando base de datos";
            List<Cliente> auxListaClientes = await Task.Run(() => {
                Thread.Sleep(2000);
                return this.dao.LeerBaseDeDatos();
            });
            this.dbStatus.Visible = false;
            return auxListaClientes;
        }
        /// <summary>
        /// Guarda el listado actual de pedidos en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarDB_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Esta seguro de querer agregar el listado actual a la base de datos?",
                    "Guardar Listado",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.dao.GuardarClientes(this.listado.ListaClientes))
                    {
                        MessageBox.Show("Se guardo correctamente el listado",
                            "Base de datos actualizada", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Elimina al cliente seleccionado de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente aux = (Cliente)this.dgListado.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show("Esta seguro de querer eliminar el cliente? Lo eliminará de la database.",
                    "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.BuscarCliente(aux) && this.dao.Borrar(aux.Codigo))
                    {
                        this.listado -= aux;
                        MessageBox.Show("Se borró el cliente",
                                "Cliente eliminado", MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.RefrescarDataGrid();
                    }
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Permite modificar los datos del cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente aux = (Cliente)this.dgListado.SelectedRows[0].DataBoundItem;
                if (this.BuscarCliente(aux))
                {
                    FrmModificarCliente frmModificarCliente = new FrmModificarCliente(aux);
                    frmModificarCliente.ShowDialog();
                    if (this.dao.ModificarCliente(aux))
                    {
                        MessageBox.Show("Se modifico el cliente",
                                "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    this.RefrescarDataGrid();
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Verifica que el cliente recibido por parametro
        /// se encuentre en la base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        private bool BuscarCliente(Cliente cliente)
        {
            bool estaIncluido = false;
            try
            {
                if (databaseListado == cliente)
                {
                    estaIncluido = true;
                }
                else
                {
                    throw new Exception("El cliente no esta en la base de datos");
                }
            } 
            catch (Exception)
            {
                throw;
            }
            return estaIncluido;
        }
        /// <summary>
        /// Muestra los detalles de la venta
        /// Con o sin codigo de descuento
        /// </summary>
        /// <param name="cliente"></param>
        private void InformarVentaExitosa(Cliente cliente)
        {
            string mensajeCodigo = "";
            if(!string.IsNullOrEmpty(this.codigoDescuento))
            {
                cliente.PrecioCompra -= cliente.PrecioCompra  * 0.2;
                mensajeCodigo = $"Codigo de descuento: {this.codigoDescuento}";
                this.codigoDescuento = "";
            }
            MessageBox.Show($"Venta confirmada:\n{cliente}{mensajeCodigo}","Venta exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /// <summary>
        /// Invoca al formulario del codigo de descuento 
        /// y asigna el atributo codigoDescuento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCodigoDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCodigoDescuento.CheckState == CheckState.Checked)
            {
                FrmCodigoDescuento frmCodigoDescuento = new FrmCodigoDescuento(this.codigoDescuento);
                frmCodigoDescuento.ShowDialog();
                this.codigoDescuento = frmCodigoDescuento.codigo;
                this.cbCodigoDescuento.Checked = false;
            }
        }
    }
}
