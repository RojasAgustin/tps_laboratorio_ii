using System;
using System.Windows.Forms;

namespace ControlesDeUsuario
{
    public partial class TxtSoloNumeros : UserControl
    {
        public TxtSoloNumeros()
        {
            InitializeComponent();
        }
        public string Texto
        {
            get
            {
                return this.txtNum.Text;
            }
            set
            {
                this.txtNum.Text = value;
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
   
}
