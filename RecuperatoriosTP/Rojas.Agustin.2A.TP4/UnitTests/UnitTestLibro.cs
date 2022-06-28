using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTests
{
    [TestClass]
    public class UnitTestLibro
    {
        [TestMethod]
        public void AgregarImpuesto_Comic()
        {
            //Arrange
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            double precioEsperado = 100 + 100 * 0.4;
            //Act Y Assert
            Assert.AreEqual(precioEsperado, comic.Precio);
        }
        [TestMethod]
        public void EqualsFunciona_Comic()
        {
            //Arrange
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            Comic comic2 = new Comic("Titulo", "Autor", 100, 199, "Editorial", ECategoria.Infantil, false);
            
            //Act Y Assert
            Assert.IsTrue(comic.Equals(comic2));
        }
        [TestMethod]
        public void AgregarImpuestos_Novela()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Otro, true);
            double precioEsperado = 100 + 100 * 0.25;
            precioEsperado += 100 * 0.5;
            //Act Y Assert
            Assert.AreEqual(precioEsperado, novela.Precio);
        }
        [TestMethod]
        public void EqualsFunciona_Novela()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Otro, true);
            Novela novela2 = new Novela("Titulo", "Autor", 100, 199, "Editorial", EGenero.Aventura, EIdiomas.Español, false);

            //Act Y Assert
            Assert.IsTrue(novela.Equals(novela2));
        }
        [TestMethod]
        public void AplicarDescuento_NoFiccion()
        {
            //Arrange
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial", ETematica.Filosofia);
            double precioEsperado = 100 - 100 * 0.2;
            //Act Y Assert
            Assert.AreEqual(precioEsperado, noFiccion.Precio);
        }
        [TestMethod]
        public void EqualsFunciona_NoFiccion()
        {
            //Arrange
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 288, "Editorial", ETematica.Filosofia);
            NoFiccion noFiccion2 = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial2", ETematica.Filosofia);

            //Act Y Assert
            Assert.IsTrue(noFiccion.Equals(noFiccion2));
        }
    }
}
