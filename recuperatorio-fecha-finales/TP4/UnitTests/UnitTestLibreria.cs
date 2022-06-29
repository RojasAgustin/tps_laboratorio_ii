using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTestLibreria
    {
        [TestMethod]
        public void AgregarLibros_Bien()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial",ETematica.Filosofia);

            Libreria<Libro> libreria = new Libreria<Libro>(3);
            int cantidadLibros;
            //Act
            libreria += novela;
            libreria += comic;
            libreria += noFiccion;
            cantidadLibros = libreria.Lista.Count;
            //Assert
            Assert.AreEqual(3,cantidadLibros); 
        }
        [TestMethod]
        public void AgregarLibros_Mal_LibroRepetido()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial", ETematica.Filosofia);
            Novela novela2 = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);

            Libreria<Libro> libreria = new Libreria<Libro>(3);
            bool estaIncluido;
            //Act
            libreria += novela;
            libreria += comic;
            libreria += noFiccion;
            libreria += novela2;

            estaIncluido = libreria == novela2;
            //Assert
            Assert.IsTrue(estaIncluido);
        }
        [TestMethod]
        public void AgregarLibros_Mal_LibreriaLlena()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial", ETematica.Filosofia);

            Libreria<Libro> libreria = new Libreria<Libro>(1);
            //Act
            libreria += novela;
            libreria += comic;
            libreria += noFiccion;

            //Assert
            Assert.IsFalse(libreria.Lista.Count == 3);
        }
        [TestMethod]
        public void BorrarLibro_Bien()
        {
            //Arrange
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Comic comic = new Comic("Titulo", "Autor", 100, 141, "Editorial", ECategoria.Infantil, true);
            NoFiccion noFiccion = new NoFiccion("Titulo", "Autor", 100, 141, "Editorial", ETematica.Filosofia);

            Libreria<Libro> libreria = new Libreria<Libro>(3);
            bool noEstaIncluido;
            
            libreria += novela;
            libreria += comic;
            libreria += noFiccion;
            //Act
            libreria -= comic;
            noEstaIncluido = libreria != comic;
            //Assert
            Assert.IsTrue(noEstaIncluido);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AbrirArchivoLibreria_MalNoEncontrado()
        {
            //Arrange
            Libreria<Libro> libreria = new Libreria<Libro>(3);
            List<Libro> auxLista = new List<Libro>();
            //Act Y Assert
            if(libreria.Leer("abc.xml",out auxLista))
            {
                libreria.Lista = auxLista;
            }
        }

    }
}
