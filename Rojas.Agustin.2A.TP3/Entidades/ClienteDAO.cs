using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteDAO
    {
        private static string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        static ClienteDAO()
        {
            ClienteDAO.cadenaConexion = @"Server=.;Database=TP_04;Trusted_Connection=True;";
        }
        public ClienteDAO()
        {
            this.conexion = new SqlConnection(ClienteDAO.cadenaConexion);
        }
        public List<Cliente> LeerBaseDeDatos()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                this.comando = new SqlCommand();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM Clientes";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = this.comando.ExecuteReader();
                while (this.lector.Read())
                {
                    int codigo = this.lector.GetInt32(0);
                    string nombre = this.lector.GetString(1);
                    string apellido = this.lector.GetString(2);
                    string email = this.lector.GetString(3);
                    string direccion = this.lector.GetString(4);
                    string telefono = this.lector.GetString(5);
                    float precioCompra = this.lector.GetFloat(6);
                    string tituloCompra = this.lector.GetString(7);

                    Cliente cliente = new Cliente(nombre,apellido,email,direccion,telefono,precioCompra,tituloCompra);
                    cliente.Codigo = codigo;

                    lista.Add(cliente);
                }
                this.lector.Close();
            }
            catch (Exception)
            {
                throw new Exception("Error al leer de la base de datos");
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return lista;
        }
        
        public bool GuardarCliente(Cliente cliente)
        {
            bool pudoGuardar = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Codigo", cliente.Codigo.ToString());
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                this.comando.Parameters.AddWithValue("@E-Mail", cliente.Correo); //-?
                this.comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                this.comando.Parameters.AddWithValue("@PrecioCompra", cliente.PrecioCompra.ToString());
                this.comando.Parameters.AddWithValue("@TituloCompra", cliente.TituloCompra);

                string sql = "INSERT INTO Clientes" +
                    " VALUES (@Codigo, @Nombre, @Apellido, @E-Mail, @Direccion, @Telefono, @PrecioCompra, @TituloCompra)";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    pudoGuardar = false;
                }
            }
            catch (Exception)
            {
                pudoGuardar = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return pudoGuardar;
        }
        public bool ModificarCliente(Cliente cliente)
        {
            bool pudoModificar = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Codigo", cliente.Codigo.ToString());
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                this.comando.Parameters.AddWithValue("@E-Mail", cliente.Correo);
                this.comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                this.comando.Parameters.AddWithValue("@PrecioCompra", cliente.PrecioCompra.ToString());
                this.comando.Parameters.AddWithValue("@TituloCompra", cliente.TituloCompra);

                string sql = "UPDATE Clientes " +
                    "SET Nombre = @Nombre, Apellido = @Apellido, E-Mail = @E-Mail, Direccion = @Direccion, " +
                    "Telefono = @Telefono, PrecioCompra = @PrecioCompra, TituloCompra = @TituloCompra  " +
                    "WHERE Codigo = @Codigo";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    pudoModificar = false;
                }
            }
            catch (Exception)
            {
                pudoModificar = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return pudoModificar;
        }
        public bool Borrar(int codigo)
        {
            bool pudoBorrar = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Codigo", codigo);
                string sql = "DELETE FROM Clientes WHERE Codigo = @Codigo";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                int filasAfectadas = this.comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    pudoBorrar = false;
                }
            }
            catch (Exception)
            {
                pudoBorrar = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return pudoBorrar;
        }
    }
}
