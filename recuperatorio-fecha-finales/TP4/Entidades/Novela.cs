using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Novela :Libro,IImpuestoPAIS
    {
        private EGenero genero;
        private EIdiomas idioma;
        private bool esHardcover;

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Novela()
        {

        }
        /// <summary>
        /// El constructor de la clase
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="precio"></param>
        /// <param name="paginas"></param>
        /// <param name="editorial"></param>
        /// <param name="genero"></param>
        /// <param name="idioma"></param>
        /// <param name="esHardcover"></param>
        public Novela(string titulo, string autor, double precio, int paginas, string editorial,EGenero genero,EIdiomas idioma,bool esHardcover) 
            : base(titulo, autor, precio, paginas, editorial)
        {
            base.tipo = ETipo.Novela;
            this.esHardcover = esHardcover;
            this.genero = genero;
            this.idioma = idioma;
        }
        /// <summary>
        /// Propiedad del atributo genero
        /// </summary>
        public EGenero Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }
        /// <summary>
        /// Propiedad del atributo idioma
        /// </summary>
        public EIdiomas Idioma
        {
            get
            {
                return this.idioma;
            }
            set
            {
                this.idioma = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo esHardcover
        /// </summary>
        public bool EsHardcover
        {
            get
            {
                return this.esHardcover;
            }
            set
            {
                this.esHardcover = value;
            }
        }

        /// <summary>
        /// Override de la propiedad abstracta de Libro que le añade
        /// al precio un aumento del 25% si es hardcover 
        /// e implementa la interfaz IImpuestoPais si la Novela no
        /// esta en español, aplicandole un impuesto al precio.
        /// </summary>
        public override double Precio
        {
            get
            {
                double precioFinal = base.precio;
                if (this.esHardcover)
                {
                    precioFinal += precioFinal * 0.25;
                }
                if(this.idioma == EIdiomas.Ingles || this.idioma == EIdiomas.Otro)
                {
                    precioFinal += this.CalcularImpuesto();
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
            string hardcover = this.esHardcover ? "Si" : "No";

            str.Append(base.Mostrar());
            str.AppendLine($"Genero: {this.genero}");
            str.AppendLine($"Idioma: {this.idioma}");
            str.AppendLine($"Hard Cover: {hardcover}");

            return str.ToString();
        }
        /// <summary>
        /// Implementacion del metodo de la interfaz IImpuestoPAIS
        /// Calcula el impuesto, que es del 50%
        /// </summary>
        /// <returns></returns>
        public double CalcularImpuesto()
        {
            double impuesto = base.precio * 0.5;
            return impuesto;
        }

        /// <summary>
        /// Compara dos novelas y verifica que sean iguales 
        /// reutilizando la sobrecarga del == de la clase base
        /// y comparando que el genero de una sea igual que la otra
        /// </summary>
        /// <param name="n1">La primera novela</param>
        /// <param name="n2">La segunda novela</param>
        /// <returns></returns>
        public static bool operator ==(Novela n1,Novela n2)
        {
            return n1 == (Libro)n2 && n1.genero == n2.genero;
        }
        /// <summary>
        /// Compara que dos novelas sean distintos reutilizando el codigo 
        /// de la sobrecarga de ==
        /// </summary>
        /// <param name="n1">La primera novela</param>
        /// <param name="n2">La segunda novela</param>
        /// <returns></returns>
        public static bool operator !=(Novela n1,Novela n2)
        {
            return !(n1 == n2);
        }

        /// <summary>
        /// Override de equals que verifica que la Novela que llama al metodo
        /// y el objeto que recibe por parametro sean iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if(obj is not null && obj is Novela && ((Novela)obj) == this)
            {
                rta = true;
            }
            return rta;
        }

       
    }
}
