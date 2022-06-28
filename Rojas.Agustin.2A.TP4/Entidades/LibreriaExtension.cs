using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class LibreriaExtension
    {
        /// <summary>
        /// Metodo publico de ordenamiento que usa expresiones lambda
        /// segun el criterio que recibe de parametro
        /// </summary>
        /// <param name="o">Criterio de ordenamiento</param>
        /// <returns></returns>
        public static void OrdenarLibros(this Libreria<Libro> libreria, EOrdenamientoLibro o)
        {
            switch (o)
            {
                case EOrdenamientoLibro.OrdenarPorPrecio:
                    libreria.Lista.Sort((libro1, libro2) => (int)(libro2.Precio - libro1.Precio));
                    break;
                case EOrdenamientoLibro.OrdenarPorTitulo:
                    libreria.Lista.Sort((libro1, libro2) => libro1.Titulo.CompareTo(libro2.Titulo));
                    break;
                case EOrdenamientoLibro.OrdenarPorPaginas:
                    libreria.Lista.Sort((libro1, libro2) => libro2.Paginas - libro1.Paginas);
                    break;
            }
        }
    }
}
