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
    public delegate void DelegadoClienteAgregado();
    public class Listado 
    {
        public event DelegadoClienteAgregado EventoClienteAgregado;

        private List<Cliente> listaClientes;

        /// <summary>
        /// Constructor de la clase que inicaliza la lista de pedidos
        /// </summary>
        /// 
        public Listado()
        {
            this.listaClientes = new List<Cliente>();
        }
        /// <summary>
        /// Propiedad de la lista de pedidos
        /// </summary>
        public List<Cliente> ListaClientes
        {
            get
            {
                return this.listaClientes;
            }
            set
            {
                this.listaClientes = value;
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
            if (c.TituloCompra is not null && c.PrecioCompra > 0)
            {
                l.listaClientes.Add(c);
                if(c is not null && l.EventoClienteAgregado is not null)
                {
                    l.EventoClienteAgregado.Invoke();
                }
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
