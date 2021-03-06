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
    public partial class FrmPrincipal : Form
    {
        private Libreria<Libro> libreria;
        private Listado listado;
        private double ganancias;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.libreria = new Libreria<Libro>(25);
            this.listado = new Listado();

        }

        /// <summary>
        /// Metodo de la etapa Load del formulario.
        /// Abre un archivo inicial para la libreria y uno para el listado.
        /// Inicializa el data grid y los ordenamientos del combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Libreria inicial
            try
            {
                List<Libro> auxListaLibros = new List<Libro>();
               
                if(this.libreria.Leer("LibreriaInicial.xml",out auxListaLibros))
                {
                    this.libreria.Lista = auxListaLibros;
                }
                
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
            //Listado de pedidos inicial
            try
            {
                List<Cliente> auxListaClientes = new List<Cliente>();
                if (this.listado.Leer("ListadoPedidosInicial.xml", out auxListaClientes))
                {
                    this.listado.ListaClientes = auxListaClientes;
                }
            }
            catch (Exception f)
            {
                this.MostrarVentanaDeError(f);
            }

            //Listado
            this.dgLibreria.DataSource = libreria.Lista;

            //Criterios de ordenamiento
            this.cboOrdenar.Items.Add("TITULO");
            this.cboOrdenar.Items.Add("PRECIO");
            this.cboOrdenar.Items.Add("PAGINAS");
            this.cboOrdenar.SelectedItem = "TITULO";
        }

        /// <summary>
        /// Usa el metodo Close para llamar al metodo FormClosing del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo del formulario para cuando se encuentra en la etapa FormClosing
        /// Se asegura que el usuario quiera salir con una ventana con botones "si" y "no"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro de querer salir?",
                                                     "Salir",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question,
                                                     MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Ordena la lista de libros segun el ordenamiento
        /// elegido en el combo box y actualiza el data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenar.SelectedItem.ToString())
            {
                case "TITULO":
                    this.libreria.OrdenarLibros(EOrdenamientoLibro.OrdenarPorTitulo);
                    break;
                case "PRECIO":
                    this.libreria.OrdenarLibros(EOrdenamientoLibro.OrdenarPorPrecio);
                    break;
                case "PAGINAS":
                    this.libreria.OrdenarLibros(EOrdenamientoLibro.OrdenarPorPaginas);
                    break;
            }
            this.RefrescarDataGrid();
        }

        /// <summary>
        /// Refresca la lista para que 
        /// ocurran los cambios
        /// </summary>
        private void RefrescarDataGrid()
        {
            this.dgLibreria.DataSource = null;
            this.dgLibreria.DataSource = this.libreria.Lista;
        }

        /// <summary>
        /// Invoca al formulario que agrega libros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (this.libreria.Lista.Count < this.libreria.CapacidadMaxima)
            {
                FrmAgregarLibro frmAgregarLibro = new FrmAgregarLibro(libreria);
                frmAgregarLibro.ShowDialog();
                this.RefrescarDataGrid();
            }
            else
            {
                MessageBox.Show("No hay mas espacio para libros","Libreria Llena", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra la informacion del libro seleccionado
        /// en un MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgLibreria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgLibreria.RowCount != 0)
                {
                    MessageBox.Show(dgLibreria.SelectedRows[0].DataBoundItem.ToString(), "Zoom", MessageBoxButtons.OK);
                }
                else
                {
                    throw new LibreriaVaciaException();
                }
            }
            catch(Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Borra al libro seleccionado de la libreria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgLibreria.RowCount != 0) 
                {
                    Libro aux = (Libro)this.dgLibreria.SelectedRows[0].DataBoundItem;
                    if (MessageBox.Show($"Estas seguro de querer borrar:\n\"{aux.Titulo}\" de {aux.Autor}?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.libreria -= aux;
                        this.RefrescarDataGrid();
                    }
                }
                else
                {
                    throw new LibreriaVaciaException();
                }
            }
            catch(Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
            
        }

        /// <summary>
        /// Invoca al formulario para agregar un pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgLibreria.RowCount != 0)
                {
                    Libro compra = (Libro)this.dgLibreria.SelectedRows[0].DataBoundItem;
                    FrmAgregarPedido frmAgregarPedido = new FrmAgregarPedido(this.listado, compra);
                    frmAgregarPedido.ShowDialog();
                }
                else
                {
                    throw new LibreriaVaciaException();
                }
            }
            catch(Exception f)
            {
                this.MostrarVentanaDeError(f);
            }
        }

        /// <summary>
        /// Invoca al formulario para ver el listado de pedidos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListadoPedido_Click(object sender, EventArgs e)
        {
            if(this.listado.ListaClientes.Count != 0)
            {
                FrmListadoPedidos frmListadoPedidos = new FrmListadoPedidos(this.listado,ganancias);
                frmListadoPedidos.ShowDialog();
                this.ganancias = frmListadoPedidos.Ganancias;
            }
            else
            {
                MessageBox.Show("No hay pedidos", "Listado vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Abre un archivo .xml que contiene una libreria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemAbrir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea abrir un archivo de libreria nuevo?\nLa libreria actual se borrará",
        "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    List<Libro> auxLista = new List<Libro>();
                    if (this.libreria.Leer("LibreriaSerializada.xml",out auxLista))
                    {
                        this.libreria.Lista = auxLista;
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
        /// Guarda la libreria actual en un archivo .xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuItemGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea guardar la libreria actual?\nEsta acción sobreescribirá los datos previamente guardados",
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (this.libreria.Lista.Count > 0)
                    {
                        if (this.libreria.Guardar("LibreriaSerializada.xml", this.libreria.Lista))
                        {
                            MessageBox.Show("Archivo guardado con exito");
                        }
                    }
                    else
                    {
                        throw new LibreriaVaciaException("La libreria esta vacia",null);
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
