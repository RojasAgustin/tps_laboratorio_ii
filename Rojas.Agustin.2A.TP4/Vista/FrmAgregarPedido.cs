using System;
using Entidades;
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
    public partial class FrmAgregarPedido : Form
    {
        private Listado listado;
        private double precioCompra;
        private string tituloCompra;

        /// <summary>
        /// Constructor del formulario
        /// </summary>
        /// <param name="listado"></param>
        /// <param name="compra"></param>
        public FrmAgregarPedido(Listado listado,double precio,string titulo)
        {
            InitializeComponent();
            this.listado = listado;
            this.precioCompra = precio;
            this.tituloCompra = titulo;
        }


        private void FrmAgregarPedido_Load(object sender, EventArgs e)
        {
            this.lblPrecio.Text += $"{this.precioCompra:C}";
        }

        /// <summary>
        /// Agrega un pedido al listado y cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                string correo = this.txtCorreo.Text;
                string direccion = this.txtDireccion.Text;
                string telefono = this.txtTelefono.Texto;
                Cliente cliente = new Cliente(nombre,apellido,correo,direccion,telefono,this.precioCompra,this.tituloCompra);
                try
                {
                    ClienteDAO dao = new ClienteDAO();
                    if (dao.GuardarCliente(cliente))
                    {
                        this.listado += cliente;
                        this.Close();
                    }
                }
                catch (PedidoInvalidoException f)
                {
                    MessageBox.Show(f.Message);
                }
                catch(ClienteDAOException f)
                {
                    MessageBox.Show(f.Message);
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
            if (string.IsNullOrWhiteSpace(txtTelefono.Texto) || txtTelefono.Texto.Length > 13 || txtTelefono.Texto.Length < 7)
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

        
    }
}
