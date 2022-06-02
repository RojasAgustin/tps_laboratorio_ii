using System;
using System.Collections.Generic;
using Entidades;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Novela novela = new Novela("El señor de los anillos", "J.R.R.Tolkien", 96, 500, "Ediciones Minotauro", EGenero.Fantastica, EIdiomas.Español, true);
            Novela novela2 = new Novela("El principito", "Antoine de Saint-Exupéry", 50, 140, "Éditions Gallimard", EGenero.Otro, EIdiomas.Otro, false);
            Novela novela3 = new Novela("Harry Potter y la piedra filosofal", "J.K Rowling", 75, 223, "Salamandra", EGenero.Fantastica, EIdiomas.Español, false);
            Novela novela4 = new Novela("El juego de Ender", "Orson Scott Card", 66, 100, "Tor Books", EGenero.CienciaFiccion, EIdiomas.Ingles, false);

            Comic comic = new Comic("X-Men #01", "Stan Lee", 20, 25, "Marvel", ECategoria.Americano, true);
            Comic comic2 = new Comic("Dragon Ball Vol. 3", "Akira Toriyama", 160, 51, "VIZ Media LLC", ECategoria.Manga, false);

            NoFiccion noFiccion = new NoFiccion("Meditaciones", "Marco Aurelio", 50, 176, "Daniel Ochoa Editor", ETematica.Filosofia);
            NoFiccion noFiccion2 = new NoFiccion("Yo sé por qué canta el pájaro enjaulado", "Maya Angelou", 80, 321, "Random House", ETematica.Biografia);



            /*Archivo ListadoPedidoInicial
            
            //Cliente cliente1 = new Cliente("Williams","Dumais", "wildumai@gmail.com", "Bv. Pedro Ignacio Castro Barros 897", "113371742",noFiccion2);
            //Cliente cliente2 = new Cliente("Gonzalo","Martinez","pitym@hotmail.com", "Gorriti Gral Jose Ignacio 878","1557332218",comic2);
            //Cliente cliente3 = new Cliente("Victoria", "Corona", "vc4881@gmail.com", "Av. Almafuerte 677", "518582414", novela2);

            //Listado listado = new Listado();
            //List<Cliente> lista = new List<Cliente>();

            listado += cliente1;
            listado += cliente2;
            listado += cliente3;

            listado.Guardar("ListadoPedidosInicial.xml", listado.ListaClientes);

            listado.Leer("ListadoInicial.xml", out lista);
            listado.ListaClientes = lista;
            Console.WriteLine(listado);*/


            ///*Archivo LibreriaInicial

            Libreria<Libro> libreria = new Libreria<Libro>(10);
            List<Libro> lista = new List<Libro>();

            libreria += comic;
            libreria += comic2;
            libreria += novela;
            libreria += novela2;
            libreria += novela3;
            libreria += novela4;
            libreria += noFiccion;
            libreria += noFiccion2;

            Console.WriteLine(libreria);
            Console.ReadLine();
           

            libreria.Guardar("LibreriaInicial.xml",libreria.Lista);

            //libreria.Leer("LibreriaInicial.xml",out lista);
            //libreria.Lista = lista;
            //Console.WriteLine(libreria);

            Console.ReadLine();
        }
    }
}
