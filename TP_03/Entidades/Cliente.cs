using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private int codigo;
        private Libro compra;
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
        /// <param name="compra"></param>
        public Cliente(string nombre,string apellido,string correo,string direccion,string telefono,Libro compra)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.codigo = new Random().Next(0, 9999);
            this.compra = compra;
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
        /// Propiedad l/e del atributo compra
        /// </summary>
        public Libro Compra
        {
            get
            {
                return this.compra;
            }
            set
            {
                this.compra = value;
            }
        }
        /// <summary>
        ///Añade todos los datos de la clase a un stringbuilder y lo retorna como un string 
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Nombre: {this.nombre} {this.apellido}");
            str.AppendLine($"Correo: {this.correo}");
            str.AppendLine($"Direccion: {this.direccion}");
            str.AppendLine($"Telefono: {this.telefono}");
            str.AppendLine($"Codigo: {this.codigo}");
            str.AppendLine($"Tipo de compra: {this.compra.Tipo}");

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
