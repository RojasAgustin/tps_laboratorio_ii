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

        public double Ganancia
        {
            get
            {
                return this.ganancias;
            }
        }
        public FrmListadoPedidos(Listado listado,double ganancias)
        {
            InitializeComponent();
            this.listado = listado;
            this.ganancias = ganancias;
        }

        private void FrmListadoPedidos_Load(object sender, EventArgs e)
        {
            //Listado
            this.dgListado.DataSource = this.listado.ListaClientes;
            this.dgListado.ReadOnly = true;

            //Criterios de ordenamiento
            this.cboOrdenar.Items.Add("NOMBRE");
            this.cboOrdenar.Items.Add("CODIGO");
            this.cboOrdenar.Items.Add("CORREO");
            this.cboOrdenar.SelectedItem = "NOMBRE";

            this.lblGanancias.Text = this.ganancias.ToString();
        }
        private void RefrescarDataGrid()
        {
            this.dgListado.DataSource = null;
            this.dgListado.DataSource = this.listado.ListaClientes;
            this.lblGanancias.Text = this.ganancias.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboOrdenar_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (this.cboOrdenar.SelectedItem.ToString())
            {
                case "NOMBRE":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorNombre);
                    break;
                case "CODIGO":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorCodigo);
                    break;
                case "CORREO":
                    this.listado.OrdenarClientes(EOrdenamientoCliente.OrdenarPorCorreo);
                    break;
            }
            this.RefrescarDataGrid();
        }

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
                MessageBox.Show(f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgListado.RowCount != 0)
                {
                    Cliente aux = (Cliente)this.dgListado.SelectedRows[0].DataBoundItem;
                    this.listado -= aux;
                    this.ganancias += aux.Compra.Precio;
                    this.RefrescarDataGrid();                    
                }
                else
                {
                    throw new LibreriaVaciaException("El listado de pedidos de clientes esta vacio", null);
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
