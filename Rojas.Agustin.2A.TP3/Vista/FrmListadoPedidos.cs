using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmListadoPedidos : Form
    {
        private Listado listado;
        private double ganancias;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="ganancias"></param>
        public FrmListadoPedidos(Listado listado,double ganancias)
        {
            InitializeComponent();
            this.listado = listado;
            this.ganancias = ganancias;
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
        /// Metodo de la etapa Load del formulario.
        /// Inicializa el data grid, los criterios de ordenamiento
        /// y el label de ganancias.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListadoPedidos_Load(object sender, EventArgs e)
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
                    Cliente aux = (Cliente)this.dgListado.SelectedRows[0].DataBoundItem;
                    this.listado -= aux;
                    this.ganancias += (int)aux.PrecioCompra;
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
        /// Guarda el listado de pedidos actual en un archivo .xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea guardar el listado actual?\nEsta acción sobreescribirá los datos previamente guardados",
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (this.listado.Guardar("ListadoPedidosSerializado.xml", this.listado.ListaClientes))
                    {
                        MessageBox.Show("Archivo guardado con exito");
                    }
                }
                catch (Exception f)
                {
                    this.MostrarVentanaDeError(f);
                }
            }
        }

        /// <summary>
        /// Abre un archivo .xml que contiene un listado de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemAbrir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea abrir un archivo de pedidos nuevo?\nLos pedidos actuales se borrarán.",
        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    List<Cliente> auxListado = new List<Cliente>();
                    if (this.listado.Leer("ListadoPedidosSerializado.xml", out auxListado))
                    {
                        this.listado.ListaClientes = auxListado;
                        MessageBox.Show("Archivo cargado con exito");
                        this.RefrescarDataGrid();
                    }
                }
                catch (Exception f)
                {
                    this.MostrarVentanaDeError(f);
                }
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
    }
}
