using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTests
{
    [TestClass]
    public class UnitTestCliente
    {
        [TestMethod]
        public void CrearCliente_Bien()
        {
            //Arrange
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            Cliente cliente = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "42881412", comic.Precio,comic.Titulo);
            
            //Act Y Assert
            Assert.AreEqual(comic.Titulo, cliente.TituloCompra);
        }
        
    }
}
