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
    public partial class FrmModificarCliente : Form
    {
        private Cliente cliente;
        private Listado listado;
        private ClienteDAO dao;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="cliente"></param>
        public FrmModificarCliente(Cliente cliente,Listado listado)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.listado = listado;
            dao = new ClienteDAO();
        }
        /// <summary>
        /// Metodo de la etapa load del formulario
        /// que asigna en los text boxes los valores
        /// actuales del cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            txtNombre.Text = this.cliente.Nombre;
            txtApellido.Text = this.cliente.Apellido;
            txtCorreo.Text = this.cliente.Correo;
            txtDireccion.Text = this.cliente.Direccion;
            txtTelefono.Texto = this.cliente.Telefono;
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

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                str.AppendLine("El nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                str.AppendLine("El apellido");
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                esValido = false;
                str.AppendLine("La direccion");
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !this.validarCorreo())
            {
                esValido = false;
                str.AppendLine("El correo electronico (con @ y terminando en .com)");
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Texto) || txtTelefono.Texto.Length < 7 || txtTelefono.Texto.Length > 13)
            {
                esValido = false;
                str.AppendLine("El telefono/celular (debe ser mayor a 7 digitos/menor a 13/solo numeros)");
            }

            if (!esValido)
            {
                MessageBox.Show(str.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return esValido;
        }

        /// <summary>
        /// Valida que el correo sea valido
        /// </summary>
        /// <returns></returns>
        private bool validarCorreo()
        {
            bool esValido = false;
            if (txtCorreo.Text.Contains("@") && txtCorreo.Text.EndsWith(".com"))
            {
                esValido = true;
            }
            return esValido;
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
        /// Actualiza los atributos del cliente a
        /// los que estan en los text boxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                Cliente aux = new Cliente();
                aux.Codigo = cliente.Codigo;
                aux.PrecioCompra = cliente.PrecioCompra;
                aux.TituloCompra = cliente.TituloCompra;
                aux.Nombre = txtNombre.Text;
                aux.Apellido = txtApellido.Text;
                aux.Correo = txtCorreo.Text;
                aux.Direccion = txtDireccion.Text;
                aux.Telefono = txtTelefono.Texto;
                if (this.dao.ModificarCliente(aux))
                {
                    MessageBox.Show("Se modifico el cliente",
                                    "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.cliente = aux;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar al cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
