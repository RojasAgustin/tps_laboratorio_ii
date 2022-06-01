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


        Comic comic = new Comic("Cusa", "Autor", 150, 11, "Editorial", ECategoria.Infantil, true);
        Novela novela = new Novela("Anonda", "Autor", 110, 141, "Editorial", EGenero.Aventura, EIdiomas.Otro, true);
        NoFiccion noFiccion = new NoFiccion("Xave", "Autor", 10, 1000, "Editorial", ETematica.Filosofia);
        Cliente cliente1;
        Cliente cliente2;
        Cliente cliente3;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.libreria = new Libreria<Libro>(25);
            this.listado = new Listado();

            this.libreria += comic;
            this.libreria += novela;
            this.libreria += noFiccion;

            this.cliente1 = new Cliente("Zabala", "Apellido", "gordopoxy@gmail.com", "Direccion", "123456789", comic);
            this.cliente2 = new Cliente("Lucas", "Apellido", "elmaspij@gmail.com", "Direccion", "123456789", novela);
            this.cliente3 = new Cliente("Almundia", "Apellido", "frabigol@gmail.com", "Direccion", "123456789", comic);

            this.listado += cliente1;
            this.listado += cliente2;
            this.listado += cliente3;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
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
        /// elegido en el combo box
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
                MessageBox.Show("No hay mas espacio para libros","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                MessageBox.Show(f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                MessageBox.Show(f.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

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
                MessageBox.Show(f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListadoPedido_Click(object sender, EventArgs e)
        {
            if(this.listado.ListaClientes.Count != 0)
            {
                FrmListadoPedidos frmListadoPedidos = new FrmListadoPedidos(this.listado,ganancias);
                frmListadoPedidos.ShowDialog();
                this.ganancias = frmListadoPedidos.Ganancia;
            }
            else
            {
                MessageBox.Show("No hay pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
