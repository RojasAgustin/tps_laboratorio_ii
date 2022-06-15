using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTestListadoClientes
    {
        [TestMethod]
        public void AgregarCliente_Bien()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Cliente cliente = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "12345678",novela.Precio,novela.Titulo);

            Listado listado = new Listado();
            //Act
            listado += cliente;
            //Assert
            Assert.IsTrue(listado == cliente);
        }
        [TestMethod]
        [ExpectedException(typeof(PedidoInvalidoException))]
        public void AgregarCliente_Mal_ClienteSinCompra()
        {
            //Arrange
            Cliente cliente = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "42881412", 0,null);
            Listado listado = new Listado();

            //Act Y Assert
            listado += cliente;

        }
        [TestMethod]
        public void BorrarCliente()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Cliente cliente = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "12345678", novela.Precio,novela.Titulo);

            Listado listado = new Listado();
            
            listado += cliente;
            //Act
            listado -= cliente;
            //Assert
            Assert.IsTrue(listado != cliente);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AbrirArchivoListadoPedidos_MalNoEncontrado()
        {
            //Arrange
            Listado listado = new Listado(); ;
            List<Cliente> auxLista = new List<Cliente>();
            //Act Y Assert
            if (listado.Leer("abc.xml", out auxLista))
            {
                listado.ListaClientes = auxLista;
            }
        }

    }
}