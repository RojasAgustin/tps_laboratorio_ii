using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoFiccion : Libro
    {
        private ETematica tematica;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public NoFiccion()
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
        /// <param name="tematica"></param>
        public NoFiccion(string titulo, string autor, double precio, int paginas, string editorial, ETematica tematica) 
            : base(titulo, autor, precio, paginas, editorial)
        {
            base.tipo = ETipo.NoFiccion;
            this.tematica = tematica;
        }

        /// <summary>
        /// Propiedad del atributo tematica
        /// </summary>
        public ETematica Tematica
        {
            get
            {
                return this.tematica;
            }
            set
            {
                this.tematica = value;
            }
        }
        /// <summary>
        /// Override de la propiedad abstracta de Libro que le añade
        /// al precio un descuento del 20% (en oferta). 
        /// </summary>
        public override double Precio
        {
            get
            {
                double precioFinal = base.precio - base.precio * 0.2;
                
                return precioFinal;
            }
            set
            {
                base.precio = value;
            }
        }
        /// <summary>
        /// Añade todos los datos de la clase Libro y la clase NoFiccion
        /// a un stringbuilder y lo retorna como string 
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.Append(base.Mostrar());
            str.AppendLine($"Tematica: {this.tematica}");

            return str.ToString();
        }
        /// <summary>
        /// Compara dos no-ficcion y verifica que sean iguales 
        /// reutilizando la sobrecarga del == de la clase base
        /// y comparando que la tematica de una sea igual que la otra
        /// </summary>
        /// <param name="nf1">El primer libro de no-ficcion</param>
        /// <param name="nf2">El segundo libro de no-ficcion</param>
        /// <returns></returns>
        public static bool operator ==(NoFiccion nf1, NoFiccion nf2)
        {
            return nf1 == (Libro)nf2 && nf1.tematica == nf2.tematica;
        }
        /// <summary>
        /// Compara que dos no-ficcion sean distintos reutilizando el codigo 
        /// de la sobrecarga de ==
        /// </summary>
        /// <param name="nf1"></param>
        /// <param name="nf2"></param>
        /// <returns></returns>
        public static bool operator !=(NoFiccion nf1, NoFiccion nf2)
        {
            return !(nf1 == nf2);
        }
        /// <summary>
        /// Override de equals que verifica que el libro de NoFiccion que llama al metodo
        /// y el objeto que recibe por parametro sean iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is not null && obj is NoFiccion && ((NoFiccion)obj) == this)
            {
                rta = true;
            }
            return rta;
        }
    }
}
