using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ClienteDAOExtension
    {
        public static bool VerificarConexion(this ClienteDAO dao,string server,string baseDeDatos)
        {
            bool pudoConectarse = true;
            SqlConnection conexion = default;
            try
            {
                if(!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(baseDeDatos))
                {
                    conexion = new SqlConnection($"Server={server};Database={baseDeDatos};Trusted_Connection=True;");
                    conexion.Open();
                }
            }
            catch (Exception)
            {
                pudoConectarse = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return pudoConectarse;
        }
    }
}
