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
    public partial class FrmReclamo : Form
    {
        private Libreria<Libro> libreria;
        /// <summary>
        /// Constructor del form
        /// </summary>
        public FrmReclamo(Libreria<Libro> libreria)
        {
            InitializeComponent();
            this.libreria = libreria;
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
        /// Guarda el reclamo en un archivo .txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(rtbReclamo.Text))
            {
                string reclamo = rtbReclamo.Text;
                try
                {
                    if (libreria.GuardarReclamo("reclamos.txt", reclamo))
                    {
                        MessageBox.Show("Se guardo con exito el reclamo","Reclamo guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ingreso un reclamo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
