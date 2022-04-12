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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor del formulario
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        /// <summary>
        /// Metodo del formulario para cuando se encuentra en la etapa Load de su ciclo de vida
        /// Settea las propiedades del combo box de operadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOperador.BackColor = Color.Snow;
            cmbOperador.Items.Add('+');
            cmbOperador.Items.Add('-');
            cmbOperador.Items.Add('*');
            cmbOperador.Items.Add('/');
            lblResultado.Text = "0";
        }

        /// <summary>
        /// Metodo del formulario para cuando se encuentra en la etapa FormClosing
        /// Se asegura que el usuario quiera salir con una ventana con botones "si" y "no"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
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
        /// Usa el metodo Close para llamar al metodo FormClosing del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Llama al metodo que lo pasa de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        { 
            Operando numero = new Operando(lblResultado.Text);
            lblResultado.Text = numero.DecimalBinario(lblResultado.Text);
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Llama al metodo que lo pasa de binario a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numero = new Operando(lblResultado.Text);
            lblResultado.Text = numero.BinarioDecimal(lblResultado.Text);
            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
            
        }
        /// <summary>
        /// Llama al metodo Limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Revisa que el contenido de los campos sea correcto,
        /// llama al metodo que devuelve el resultado de la operacion y
        /// muestra el resultado en el label y en el list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultadoAMostrar;
            if (cmbOperador.SelectedIndex < 0 || string.IsNullOrEmpty(txtNumero1.Text) || string.IsNullOrEmpty(txtNumero2.Text))
            {
                MessageBox.Show("Rellene todos los campos","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (double.TryParse(txtNumero1.Text, out double num) && double.TryParse(txtNumero2.Text, out num))
                {
                    double resultadoOperacion = FormCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString());
                    if(resultadoOperacion == 0)
                    {
                        resultadoAMostrar = "0";
                    }
                    else
                    {
                        resultadoAMostrar = resultadoOperacion.ToString("#.###");
                    }
                    lblResultado.Text = resultadoAMostrar;
                    lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.SelectedItem.ToString()} {txtNumero2.Text} = {resultadoAMostrar}");
                    btnConvertirABinario.Enabled = true;
                    btnConvertirADecimal.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingrese solo numeros","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Restaura los valores de cada campo del formulario a su valor por defecto
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.ResetText();
            cmbOperador.SelectedIndex = -1;
            txtNumero2.ResetText();
            lblResultado.Text = "0";
            lstOperaciones.Items.Clear();
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        /// <summary>
        /// Llama al metodo de la clase Calculadora que realiza la operacion
        /// y devuelve el resultado
        /// </summary>
        /// <param name="numero1">El primer operando</param>
        /// <param name="numero2">El segundo operando</param>
        /// <param name="operador">El operador</param>
        /// <returns>El resultado de la operacion</returns>
        private static double Operar(string numero1,string numero2,string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2); 
            return Calculadora.Operar(operando1, operando2, char.Parse(operador));
        }
        
    }
}
