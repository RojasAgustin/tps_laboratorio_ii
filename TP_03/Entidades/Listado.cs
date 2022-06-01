using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Listado
    {
        private List<Cliente> listaClientes;

        /// <summary>
        /// Constructor de la clase que inicaliza la lista de pedidos
        /// </summary>
        public Listado()
        {
            this.listaClientes = new List<Cliente>();
        }
        /// <summary>
        /// Propiedad de solo lectura de la lista de pedidos
        /// </summary>
        public List<Cliente> ListaClientes
        {
            get
            {
                return this.listaClientes;
            }
        }
        /// <summary>
        /// Añade todos los clientes de la lista 
        /// a un stringbuilder y lo devuelve como string 
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static string Mostrar(Listado l)
        {
            StringBuilder str = new StringBuilder();
            foreach (Cliente item in l.listaClientes)
            {
                str.AppendLine();
                str.Append(item);
                str.AppendLine();
            }
            return str.ToString();
        }
        /// <summary>
        /// Metodo publico de ordenamiento que llama a 
        /// un metodo de ordenamiento segun el criterio
        /// que recibe de parametro
        /// </summary>
        /// <param name="o">Criterio de ordenamiento</param>
        public void OrdenarClientes(EOrdenamientoCliente o)
        {
            switch (o)
            {
                case EOrdenamientoCliente.OrdenarPorCodigo:
                    this.listaClientes.Sort(OrdenarPorCodigo);
                    break;
                case EOrdenamientoCliente.OrdenarPorCorreo:
                    this.listaClientes.Sort(OrdenarPorCorreo);
                    break;
                case EOrdenamientoCliente.OrdenarPorNombre:
                    this.listaClientes.Sort(OrdenarPorNombre);
                    break;
            }
        }
        /// <summary>
        /// Ordena dos clientes de la lista  por 
        /// sus atributos codigo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorCodigo(Cliente a, Cliente b)
        {
            int rt = 0;
            if (a.Codigo > b.Codigo)
            {
                rt = 1;
            }
            else if (a.Codigo < b.Codigo)
            {
                rt = -1;
            }
            return rt;
        }
        /// <summary>
        /// Ordena dos clientes de la lista  por 
        /// sus atributos correo
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorCorreo(Cliente a, Cliente b)
        {
            return String.Compare(a.Correo, b.Correo);
        }
        /// <summary>
        /// Ordena dos clientes de la lista  por 
        /// sus atributos nombre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int OrdenarPorNombre(Cliente a, Cliente b)
        {
            return String.Compare(a.Nombre, b.Nombre);
        }
        /// <summary>
        /// Se fija si un cliente que recibe de parametro 
        /// ya esta incluido en la lista de pedidos
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator ==(Listado l,Cliente c)
        {
            bool estaIncluido = false;
            foreach (Cliente item in l.listaClientes)
            {
                if (item.Equals(c))
                {
                    estaIncluido = true;
                    break;
                }
            }
            return estaIncluido;
        }
        /// <summary>
        /// Se fija que un cliente no este incluido en la lista
        /// reutilizando el codigo de la sobrecarga ==
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator !=(Listado l,Cliente c)
        {
            return !(l == c);
        }
        /// <summary>
        /// Añade un cliente a la lista a la lista de pedidos
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Listado operator +(Listado l,Cliente c)
        {
            if (c.Compra is not null)
            {
                l.listaClientes.Add(c);
            }
            else
            {
                throw new PedidoInvalidoException();
            }
            return l;
        }
        /// <summary>
        /// Elimina un cliente de la lista de pedidos
        /// si se encuentra incluido
        /// </summary>
        /// <param name="l"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Listado operator -(Listado l,Cliente c)
        {
            if (l == c)
            {
                l.listaClientes.Remove(c);
            }
            return l;
        }
        /// <summary>
        /// Llama al metodo estatico Mostrar para
        /// mostrar todos los clientes del listado
        /// de pedidos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Listado.Mostrar(this);
        }
    }
}
