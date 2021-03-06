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
using ControlesDeUsuario;

namespace Vista
{
    public partial class FrmAgregarLibro : Form
    {
        Libreria<Libro> libreria;

        /// <summary>
        /// Constructor del formulario 
        /// </summary>
        /// <param name="libreria"></param>
        public FrmAgregarLibro(Libreria<Libro> libreria)
        {
            InitializeComponent();
            this.libreria = libreria;
        }

        /// <summary>
        /// Metodo de la etapa Load del formulario.
        /// Llama al metodo del radio button de novela
        /// para que el formulario comience con los campos
        /// de novela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarLibro_Load(object sender, EventArgs e)
        {
            this.rbtnNovela_CheckedChanged(sender, e);
        }

        /// <summary>
        /// Cambia a los campos del tipo Novela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnNovela_CheckedChanged(object sender, EventArgs e)
        {
            //Genero
            this.cboClasificacion.Items.Clear();
            this.lblClasificacion.Text = "GENERO";
            this.cboClasificacion.Items.Add("Aventura");
            this.cboClasificacion.Items.Add("CienciaFiccion");
            this.cboClasificacion.Items.Add("Fantastica");
            this.cboClasificacion.Items.Add("Paranormal");
            this.cboClasificacion.Items.Add("Policiaca");
            this.cboClasificacion.Items.Add("Romantica");
            this.cboClasificacion.Items.Add("Humor");
            this.cboClasificacion.Items.Add("Otro");

            //Idioma
            this.lblIdioma.Text = "IDIOMA";
            this.cboIdioma.Items.Clear();
            this.cboIdioma.Items.Add("Español");
            this.cboIdioma.Items.Add("Ingles");
            this.cboIdioma.Items.Add("Otro");
            this.cboIdioma.Show();

            //Booleano
            this.lblBooleano.Text = "HARDCOVER";
            this.cbBooleano.Show();
        }

        /// <summary>
        /// Cambia a los campos del tipo Comic
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnComic_CheckedChanged(object sender, EventArgs e)
        {
            //Categoria     
            this.cboClasificacion.Items.Clear();
            this.lblClasificacion.Text = "CATEGORIA";
            this.cboClasificacion.Items.Add("Manga");
            this.cboClasificacion.Items.Add("NovelaGrafica");
            this.cboClasificacion.Items.Add("Americano");
            this.cboClasificacion.Items.Add("Infantil");
            this.cboClasificacion.Items.Add("ArtBook");
            this.cboClasificacion.Items.Add("Nacional");
            this.cboClasificacion.Items.Add("Otro");

            //Idioma
            this.cboIdioma.Hide();
            this.lblIdioma.Text = "";

            //Booleano
            this.lblBooleano.Text = "A COLOR";
            this.cbBooleano.Show();
        }

        /// <summary>
        /// Cambia a los campos del tipo NoFiccion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnNoFiccion_CheckedChanged(object sender, EventArgs e)
        {
            //Tematica
            this.cboClasificacion.Items.Clear();
            this.lblClasificacion.Text = "TEMATICA";
            this.cboClasificacion.Items.Add("Biografia");
            this.cboClasificacion.Items.Add("Memoria");
            this.cboClasificacion.Items.Add("Filosofia");
            this.cboClasificacion.Items.Add("Religion");
            this.cboClasificacion.Items.Add("Politica");
            this.cboClasificacion.Items.Add("Salud");
            this.cboClasificacion.Items.Add("Autoayuda");
            this.cboClasificacion.Items.Add("Academico");
            this.cboClasificacion.Items.Add("Otro");

            //Idioma
            this.cboIdioma.Hide();
            this.lblIdioma.Text = "";

            //Booleano
            this.cbBooleano.Hide();
            this.lblBooleano.Text = "";
        }

        /// <summary>
        /// Llama al metodo de la etapa FormClosing
        /// para cerrar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        /// <summary>
        /// Agrega un libro a la lista y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                string autor = this.txtAutor.Text;
                string titulo = this.txtTitulo.Text;
                string editorial = this.txtEditorial.Text;
                double precio = double.Parse(this.txtPrecio.Texto);
                int paginas = int.Parse(this.txtPaginas.Texto);
                if (this.rbtnNovela.Checked)
                {
                    EGenero genero = (EGenero)Enum.Parse(typeof(EGenero), this.cboClasificacion.SelectedItem.ToString());
                    EIdiomas idioma = (EIdiomas)Enum.Parse(typeof(EIdiomas), this.cboIdioma.SelectedItem.ToString());
                    bool hardcover = this.cbBooleano.Checked;

                    Novela novela = new Novela(titulo, autor, precio, paginas, editorial, genero, idioma, hardcover);
                    if(MessageBox.Show($"Estas seguro de querer agregar la novela:\n\"{titulo}\" de {autor} ({editorial})?","Confirmar",MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.libreria += novela;
                        this.Close();
                    }
                }
                else
                {
                    if (this.rbtnComic.Checked)
                    {
                        ECategoria categoria = (ECategoria)Enum.Parse(typeof(ECategoria),this.cboClasificacion.SelectedItem.ToString());
                        bool color = this.cbBooleano.Checked;

                        Comic comic = new Comic(titulo, autor, precio, paginas, editorial, categoria, color);
                        if (MessageBox.Show($"Estas seguro de querer agregar el comic:\n\"{titulo}\" de {autor} ({editorial})?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.libreria += comic;
                            this.Close();
                        }
                    }
                    else
                    {
                        if (this.rbtnNoFiccion.Checked)
                        {
                            ETematica tematica = (ETematica)Enum.Parse(typeof(ETematica), this.cboClasificacion.SelectedItem.ToString());

                            NoFiccion noficcion = new NoFiccion(titulo, autor, precio, paginas, editorial, tematica);
                            if (MessageBox.Show($"Estas seguro de querer agregar el libro:\n\"{titulo}\" de {autor} ({editorial})?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                this.libreria += noficcion;
                                this.Close();
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Valida que todos los campos no esten vacios/sean validos.
        /// De no ser asi muestra cuales estan mal
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            bool esValido = true;
            StringBuilder str = new StringBuilder();
            str.AppendLine("Se deben completar los siguientes campos:"); 

            if (string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                esValido = false;
                str.AppendLine("El autor");
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                esValido = false;
                str.AppendLine("El titulo");
            }
            if (string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                esValido = false;
                str.AppendLine("La editorial");
            }
            if (string.IsNullOrWhiteSpace(txtPaginas.Texto) || txtPaginas.Texto.Length > 6)
            {
                esValido = false;
                str.AppendLine("El numero de paginas");
            }
            if (string.IsNullOrWhiteSpace(txtPrecio.Texto) || txtPrecio.Texto.Length > 6)
            {
                esValido = false;
                str.AppendLine("El precio");
            }
            if (string.IsNullOrWhiteSpace((string)cboClasificacion.SelectedItem))
            {
                esValido = false;
                str.AppendLine("La clasificacion");
            }
            if (rbtnNovela.Checked)
            {
                if (string.IsNullOrWhiteSpace((string)cboIdioma.SelectedItem))
                {
                    esValido = false;
                    str.AppendLine("El idioma");
                }
            }
            if (!esValido)
            {
                MessageBox.Show(str.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return esValido;
        }

    }
}
