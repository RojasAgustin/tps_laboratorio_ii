using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteDAOException : Exception
    {

        /// <summary>
        /// Constructor de la excepcion que reutiliza 
        /// la otra sobrecarga, con un mensaje particular
        /// y usando null como InnerException
        /// </summary>
        public ClienteDAOException() : this("Error al conectarse con la base de datos", null)
        {

        }

        /// <summary>
        /// Constructor de la excepcion que recibe un mensaje y
        /// una innerException
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ClienteDAOException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
}
