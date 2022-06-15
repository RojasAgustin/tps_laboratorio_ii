using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IArchivos<T> where T : new()
    {
       /// <summary>
       /// Metodo para guardar una lista recibida por parametro en un archivo
       /// Retorna true si pudo guardar el archivo, false si no.
       /// </summary>
       /// <param name="path">La ruta del archivo</param>
       /// <param name="lista">La lista</param>
       /// <returns></returns>
        bool Guardar(string path,T lista);

        /// <summary>
        /// Metodo para leer un archivo y guardar su contenido en el 
        /// parametro lista que recibe.
        /// Retorna true si pudo guardar el archivo, false si no.
        /// </summary>
        /// <param name="path">La ruta del archivo</param>
        /// <param name="lista">La lista</param>
        /// <returns></returns>
        
        bool Leer(string path,out T lista);
    }
}
