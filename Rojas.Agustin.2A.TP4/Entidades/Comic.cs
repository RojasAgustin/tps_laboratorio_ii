using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comic : Libro
    {
        private ECategoria categoria;
        private bool esColor;
        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Comic()
        {

        }
        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="precio"></param>
        /// <param name="paginas"></param>
        /// <param name="editorial"></param>
        /// <param name="categoria"></param>
        /// <param name="esColor"></param>
        public Comic(string titulo, string autor, double precio, int paginas, string editorial,ECategoria categoria,bool esColor) 
            : base(titulo, autor, precio, paginas, editorial)
        {
            base.tipo = ETipo.Comic;
            this.categoria = categoria;
            this.esColor = esColor;
        }
        /// <summary>
        /// Propiedad l/e del atributo categoria
        /// </summary>
        public ECategoria Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo esColor
        /// </summary>
        public bool EsColor
        {
            get
            {
                return this.esColor;
            }
            set
            {
                this.esColor = value;
            }
        }

        /// <summary>
        /// Override de la propiedad abstracta de Libro que le añade
        /// al precio un aumento del 40% si esColor es true  
        /// </summary>
        public override double Precio
        {
            get
            {
                double precioFinal = base.precio;
                if (this.esColor)
                {
                    precioFinal += base.precio * 0.4;
                }
                return precioFinal;
            }
            set
            {
                base.precio = value;
            }
        }

        /// <summary>
        /// Añade todos los datos de la clase Libro y la clase Novela
        /// a un stringbuilder y lo retorna como string 
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            string color = this.esColor ? "Si" : "No";
            str.Append(base.Mostrar());
            str.AppendLine($"Categoria: {this.categoria}");
            str.AppendLine($"Es color: {color}");

            return str.ToString();
        }
        /// <summary>
        /// Compara dos comics y verifica que sean iguales 
        /// reutilizando la sobrecarga del == de la clase base
        /// y comparando que la categoria de una sea igual que la otra
        /// </summary>
        /// <param name="c1">El primer comic</param>
        /// <param name="c2">El segundo comic</param>
        /// <returns></returns>
        public static bool operator ==(Comic c1, Comic c2)
        {
            return c1 == (Libro)c2 && c1.categoria == c2.categoria;
        }
        /// <summary>
        /// Compara que dos comics sean distintos reutilizando el codigo 
        /// de la sobrecarga de ==
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Comic c1, Comic c2)
        {
            return !(c1 == c2);
        }
        /// <summary>
        /// Override de equals que verifica que el Comic que llama al metodo
        /// y el objeto que recibe por parametro sean iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is not null && obj is Comic && ((Comic)obj) == this)
            {
                rta = true;
            }
            return rta;
        }

    }
}
