using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Novela))]
    [XmlInclude(typeof(Comic))]
    [XmlInclude(typeof(NoFiccion))]
    public abstract class Libro
    {
        protected string titulo;
        protected string autor;
        protected double precio;
        protected int paginas;
        protected string editorial;
        protected ETipo tipo;

        /// <summary>
        /// Constructor por defecto de la clase
        /// </summary>
        public Libro()
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
        public Libro(string titulo,string autor,double precio,int paginas,string editorial)
        {
            this.autor = autor;
            this.titulo = titulo;
            this.precio = precio;
            this.paginas = paginas;
            this.editorial = editorial;        
        }

        /// <summary>
        /// Propiedad del atributo titulo
        /// </summary>
        public string Titulo
        {
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }
        /// <summary>
        /// Propiedad del atributo autor
        /// </summary>
        public string Autor
        {
            get
            {
                return this.autor;
            }
            set
            {
                this.autor = value;
            }
        }
        /// <summary>
        /// Propiedad del atributo editorial
        /// </summary>
        public string Editorial
        {
            get
            {
                return this.editorial;
            }
            set
            {
                this.editorial = value;
            }
        }
        /// <summary>
        /// Propiedad del atributo paginas
        /// </summary>
        public int Paginas
        {
            get
            {
                return this.paginas;
            }
            set
            {
                this.paginas = value;
            }
        }
        /// <summary>
        /// Propiedad abstracta del atributo precio, que tiene sus implementaciones
        /// en las clases derivadas
        /// </summary>
        public abstract double Precio{ get; set; }
        /// <summary>
        /// Propiedad del atributo Tipo
        /// </summary>
        public ETipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        /// <summary>
        ///Añade todos los datos de la clase a un stringbuilder y lo retorna como string 
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.tipo.ToString() + " \n");
            str.AppendLine($"Titulo: {this.titulo} ");
            str.AppendLine($"Autor: {this.autor} ");
            str.AppendLine($"Precio: {this.Precio:C} ");
            str.AppendLine($"Paginas: {this.paginas} ");
            str.AppendLine($"Editorial: {this.editorial} ");

            return str.ToString();
        }
        /// <summary>
        /// Llama al metodo Mostrar para mostrar todos los datos de la clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Compara dos libros y verifica que sean iguales
        /// siempre y cuando tengan el mismo autor, titulo y precio
        /// </summary>
        /// <param name="l1">El primer libro</param>
        /// <param name="l2">El segundo libro</param>
        /// <returns></returns>
        public static bool operator ==(Libro l1,Libro l2)
        {
            return l1.autor == l2.autor && l1.titulo == l2.titulo && l1.precio == l2.precio;
        }
        /// <summary>
        /// Compara que dos libros sean distintos reutilizando el codigo 
        /// de la sobrecarga de ==
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static bool operator !=(Libro l1,Libro l2)
        {
            return !(l1 == l2);
        }
       

    }
}
