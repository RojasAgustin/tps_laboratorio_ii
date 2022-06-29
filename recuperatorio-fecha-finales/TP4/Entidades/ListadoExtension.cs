using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class ListadoExtension
    {
        /// <summary>
        /// Metodo publico de ordenamiento que usa expresiones lambda
        /// segun el criterio que recibe de parametro
        /// </summary>
        /// <param name="o">Criterio de ordenamiento</param>
        /// <returns></returns>
        public static void OrdenarClientes(this Listado listado,EOrdenamientoCliente o)
        {
            switch (o)
            {
                case EOrdenamientoCliente.OrdenarPorPrecio:
                    listado.ListaClientes.Sort((cliente1, cliente2) => (int)(cliente2.PrecioCompra - cliente1.PrecioCompra));
                    break;
                case EOrdenamientoCliente.OrdenarPorCodigo:
                    listado.ListaClientes.Sort((cliente1, cliente2) => cliente1.Codigo - cliente2.Codigo);
                    break;
                case EOrdenamientoCliente.OrdenarPorNombre:
                    listado.ListaClientes.Sort((cliente1, cliente2) => cliente1.Nombre.CompareTo(cliente2.Nombre));
                    break;
            }
        }
    }
}
