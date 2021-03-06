using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Libreria<T>: IArchivos<List<Libro>> 
        where T : Libro
    {
        private int capacidadMaxima;
        private List<T> lista;

        /// <summary>
        /// Constructor de la clase que inicializa la lista
        /// </summary>
        public Libreria()
        {
            this.lista = new List<T>();
        }
        /// <summary>
        /// Constructor publico de la clase
        /// </summary>
        /// <param name="capacidadMaxima"></param>
        public Libreria(int capacidadMaxima) : this()
        {
            this.capacidadMaxima = capacidadMaxima;
        }
        /// <summary>
        /// Propiedad de la lista generica
        /// </summary>
        public List<T> Lista
        {
            get
            {
                return this.lista;
            }
            set
            {
                this.lista = value;
            }
        }
        /// <summary>
        /// Propiedad del atributo capacidadMaxima
        /// </summary>
        public int CapacidadMaxima
        {
            get
            {
                return this.capacidadMaxima;
            }
            set
            {
                this.capacidadMaxima = value;
            }
        }


        /// <summary>
        /// Metodo publico de ordenamiento que llama a 
        /// un metodo de ordenamiento segun el criterio
        /// que recibe de parametro
        /// </summary>
        /// <param name="o">Criterio de ordenamiento</param>
        public void OrdenarLibros(EOrdenamientoLibro o)
        {
            switch (o)
            {
                case EOrdenamientoLibro.OrdenarPorPrecio:
                    this.lista.Sort(OrdenarPorPrecio);
                    break;
                case EOrdenamientoLibro.OrdenarPorTitulo:
                    this.lista.Sort(OrdenarPorTitulo);
                    break;
                case EOrdenamientoLibro.OrdenarPorPaginas:
                    this.lista.Sort(OrdenarPorPaginas);
                    break;
            }
        }
        /// <summary>
        /// Ordena dos elementos de la lista generica por 
        /// sus atributos precio
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorPrecio(T a, T b)
        {
            int rt = 0;
            if (a.Precio > b.Precio)
            {
                rt = -1;
            }
            else if (a.Precio < b.Precio)
            {
                rt = 1;
            }
            return rt;
        }
        /// <summary>
        /// Ordena dos elementos de la lista generica por 
        /// sus atributos paginas
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorPaginas(T a, T b)
        {
            int rt = 0;
            if (a.Paginas > b.Paginas)
            {
                rt = -1;
            }
            else if (a.Paginas < b.Paginas)
            {
                rt = 1;
            }
            return rt;
        }
        /// <summary>
        /// Ordena dos elementos de la lista generica por 
        /// sus atributos titulo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorTitulo(T a,T b)
        {
            return String.Compare(a.Titulo, b.Titulo);
        }
        /// <summary>
        /// Añade todos los elementos de la lista generica
        /// a un stringbuilder y lo devuelve como string 
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static string Mostrar(Libreria<T> l)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat($"Libreria");
            str.AppendLine();
            foreach (T item in l.lista)
            {
                str.Append(item);
                str.AppendLine();
            }
            return str.ToString();
        }
        /// <summary>
        /// Se fija si un objeto que recibe de parametro 
        /// ya esta incluido en la lista generica
        /// </summary>
        /// <param name="l"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Libreria<T> l ,T a)
        {
            bool estaIncluido = false;
            foreach (T item in l.lista)
            {
                if (item.Equals(a))
                {
                    estaIncluido = true;
                    break;
                }
            }
            return estaIncluido;
        }
        /// <summary>
        /// Se fija que un objeto no este incluido en la lista
        /// reutilizando el codigo de la sobrecarga ==
        /// </summary>
        /// <param name="l"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Libreria<T> l,T a)
        {
            return !(l == a);
        }
        /// <summary>
        /// Añade un objeto a la lista si 
        /// no esta incluido y hay espacio
        /// </summary>
        /// <param name="l"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Libreria<T> operator +(Libreria<T> l, T a)
        {
            if (l.lista.Count < l.capacidadMaxima)
            {
                if (l != a)
                {
                    l.lista.Add(a);
                }
            }
            return l;
        }
        /// <summary>
        /// Elimina un elemento de la lista
        /// si se encuentra incluido en ella.
        /// </summary>
        /// <param name="l"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Libreria<T> operator -(Libreria<T> l, T a)
        {
            if (l == a)
            {
                l.lista.Remove(a);
            }
            return l;
        }
        /// <summary>
        /// Llama al metodo estatico Mostrar para mostrar todos 
        /// los elementos de la lista
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Libreria<T>.Mostrar(this);
        }

        /// <summary>
        /// Implementacion del metodo de guardar de la interfaz IArchivos
        /// trabajando con un documento .xml
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public bool Guardar(string path,List<Libro> lista)
        {
            bool pudoGuardar = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(path, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Libro>));
                    ser.Serialize(writer, lista);
                    pudoGuardar = true;
                }
            }
            catch(Exception)
            {
                throw new Exception("Error al guardar la libreria en formato XML");
            }
            return pudoGuardar;
        }

        /// <summary>
        /// Implementacion del metodo de leer de la interfaz IArchivos
        /// trabajando con un documento .xml
        /// </summary>
        /// <param name="path"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public bool Leer(string path,out List<Libro> lista)
        {
            bool pudoLeer = false;
            lista = default;
            try
            {
                if(path is not null)
                {
                    using (XmlTextReader reader = new XmlTextReader(path))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(List<Libro>));
                        lista = (List<Libro>)ser.Deserialize(reader);
                    }
                    pudoLeer = true;
                }
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("No se encontro el archivo .XML");
            }
            catch (Exception)
            {
                throw new Exception("Error al leer el archivo de la libreria en formato XML");
            }
            return pudoLeer;
        }
    }
}
