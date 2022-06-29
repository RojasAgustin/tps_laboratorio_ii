using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmCodigoDescuento : Form
    {
        public string codigo;
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public FrmCodigoDescuento(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
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
        /// Guarda lo escrito en el text box como codigo
        /// y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                this.codigo = txtCodigo.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ingreso un codigo de descuento","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
