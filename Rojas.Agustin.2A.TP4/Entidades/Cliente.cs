using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{

    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string correo;
        private string direccion;
        private string telefono;
        private double precioCompra;
        private string tituloCompra;
        private int codigo;
        /// <summary>
        /// Constructor por defecto de la clase 
        /// para serializacion
        /// </summary>
        public Cliente()
        {

        }
        /// <summary>
        /// El constructor de la clase
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="correo"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        /// <param name="precio"></param>
        /// <param name="titulo"></param>

        public Cliente(string nombre,string apellido,string correo,string direccion,string telefono,double precio,string titulo)
        {
            this.codigo = new Random().Next(0, 99999);
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.precioCompra = precio;
            this.tituloCompra = titulo;
        }
        /// <summary>
        /// Propiedad l/e del atributo codigo
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo correo
        /// </summary>
        public string Correo
        {
            get
            {
                return this.correo;
            }
            set
            {
                this.correo = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo direccion
        /// </summary>
        public string Direccion
        {
            get
            {
                return this.direccion;
            }
            set
            {
                this.direccion = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo telefono
        /// </summary>
        public string Telefono
        {
            get
            {
                return this.telefono;
            }
            set
            {
                this.telefono = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo precioCompra
        /// </summary>
        public double PrecioCompra
        {
            get
            {
                return this.precioCompra;
            }
            set
            {
                this.precioCompra = value;
            }
        }
        /// <summary>
        /// Propiedad l/e del atributo tituloCompra
        /// </summary>
        public string TituloCompra
        {
            get
            {
                return this.tituloCompra;
            }
            set
            {
                this.tituloCompra = value;
            }
        }
        /// <summary>
        ///Añade todos los datos de la clase a un stringbuilder y lo retorna como un string 
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder str = new StringBuilder();
           
            str.AppendLine($"Codigo de compra: {this.codigo}");
            str.AppendLine($"Nombre: {this.nombre} {this.apellido}");
            str.AppendLine($"Correo: {this.correo}");
            str.AppendLine($"Direccion: {this.direccion}");
            str.AppendLine($"Telefono: {this.telefono}");
            str.AppendLine($"Precio de compra: {this.precioCompra:C}");
            str.AppendLine($"Titulo/s de compra: \"{this.tituloCompra}\"");

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
        /// Compara dos clientes y verifica que sean iguales
        /// segun su codigo y su telefono
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator ==(Cliente c1,Cliente c2)
        {
            return c1.codigo == c2.codigo && c1.telefono == c2.telefono;
        }
        /// <summary>
        /// Compara que dos clientes sean distintos
        /// reutilizando la sobrecarga del ==
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }
        /// <summary>
        /// Override de equals que verifica que el Cliente que llama al metodo
        /// y el objeto que recibe por parametro sean iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool rta = false;
            if (obj is not null && obj is Cliente && ((Cliente)obj) == this)
            {
                rta = true;
            }
            return rta;
        }
        

    }
}
