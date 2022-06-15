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
        /// <summary>
        /// Verifica que se pueda establecer una conexion exitosa
        /// con el servidor y la base de datos que recibe de parametro
        /// </summary>
        /// <param name="dao"></param>
        /// <param name="server"></param>
        /// <param name="baseDeDatos"></param>
        /// <returns></returns>
        public static bool VerificarConexion(this ClienteDAO dao,string server,string baseDeDatos)
        {
            bool pudoConectarse = true;
            try
            {
                if(!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(baseDeDatos))
                {
                    dao.conexion = new SqlConnection($"Server={server};Database={baseDeDatos};Trusted_Connection=True;");
                    dao.conexion.Open();
                }
            }
            catch (Exception)
            {
                pudoConectarse = false;
                throw new Exception("Error al conectarse a la base de datos");
            }
            finally
            {
                if (dao.conexion.State == ConnectionState.Open)
                {
                    dao.conexion.Close();
                }
            }
            return pudoConectarse;
        }
    }
}
