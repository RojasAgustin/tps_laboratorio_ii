﻿using System;
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
        public SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Constructor estatico que asigna una cadena
        /// con el servidor y la base de datos al atributo
        /// que se usara en el objeto SqlConnection
        /// </summary>
        static ClienteDAO()
        {
            ClienteDAO.cadenaConexion = @"Server=.;Database=TP_04;Trusted_Connection=True;";
        }

        /// <summary>
        /// Inicializa el atributo conexion con la cadena asignada
        /// en el constructor estatico
        /// </summary>
        public ClienteDAO()
        {
            this.conexion = new SqlConnection(ClienteDAO.cadenaConexion);
        }

        /// <summary>
        /// Lee el listado de la base de datos 
        /// y lo devuelve como una lista de clientes
        /// </summary>
        /// <returns></returns>
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
                    double precioCompra = this.lector.GetDouble(6);
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
        
        /// <summary>
        /// Guarda la lista que recibe de parametro 
        /// en la base de datos
        /// </summary>
        /// <param name="clientes"></param>
        /// <returns></returns>
        public bool GuardarClientes(List<Cliente> clientes)
        {
            bool pudoGuardar = false;
            if (clientes.Count > 0)
            {
                pudoGuardar = true;
                try
                {
                    foreach (Cliente cliente in clientes)
                    {
                        this.comando = new SqlCommand();
                        this.comando.Parameters.AddWithValue("@Codigo", cliente.Codigo.ToString());
                        this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                        this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                        this.comando.Parameters.AddWithValue("@Correo", cliente.Correo);
                        this.comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                        this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        this.comando.Parameters.AddWithValue("@PrecioCompra", cliente.PrecioCompra);
                        this.comando.Parameters.AddWithValue("@TituloCompra", cliente.TituloCompra);

                        string sql = "INSERT INTO Clientes" +
                            " VALUES (@Codigo, @Nombre, @Apellido, @Correo, @Direccion, @Telefono, @PrecioCompra, @TituloCompra)";

                        this.comando.CommandType = CommandType.Text;
                        this.comando.CommandText = sql;
                        this.comando.Connection = this.conexion;

                        this.conexion.Open();
                        int filasAfectadas = this.comando.ExecuteNonQuery();
                        if (filasAfectadas == 0)
                        {
                            pudoGuardar = false;
                        }
                        this.conexion.Close();
                    }
                }
                catch (SqlException)
                {
                    pudoGuardar = false;
                    throw new Exception("Error al guardar el pedido en la base de datos. El titulo de la compra es demasiado largo\n" +
                        "Lo hice con varchar(200)");
                }
                catch (Exception)
                {
                    pudoGuardar = false;
                    throw new Exception("Hay pedidos en el listado que ya estan en la base de datos. Atiendalos antes de guardar");
                }
                finally
                {
                    if(this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
            else
            {
                throw new Exception("El listado de pedidos de clientes esta vacio");
            }
            return pudoGuardar;
        }

        /// <summary>
        /// Modifica un registro de cliente en la base de datos
        /// con los valores que tiene el cliente recibido
        /// por parametro
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool ModificarCliente(Cliente cliente)
        {
            bool pudoModificar = true;
            try
            {
                this.comando = new SqlCommand();
                this.comando.Parameters.AddWithValue("@Codigo", cliente.Codigo.ToString());
                this.comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                this.comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                this.comando.Parameters.AddWithValue("@Correo", cliente.Correo);
                this.comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                this.comando.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                this.comando.Parameters.AddWithValue("@PrecioCompra", cliente.PrecioCompra.ToString());
                this.comando.Parameters.AddWithValue("@TituloCompra", cliente.TituloCompra);

                string sql = "UPDATE Clientes " +
                    "SET Nombre = @Nombre, Apellido = @Apellido, Correo = @Correo, Direccion = @Direccion, " +
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

        /// <summary>
        /// Borra de la base de datos al cliente cuyo codigo
        /// sea igual al recibido por parametro
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
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
