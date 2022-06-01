using System;
using Entidades;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Novela novela = new Novela("Titulo", "Autor", 100, 141, "Editorial", EGenero.Aventura, EIdiomas.Español, true);
            Cliente cliente = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "12345678", novela);
            Cliente cliente2 = new Cliente("Nombre", "Apellido", "Correo@gmail.com", "Direccion", "12345678", novela);

            Listado listado = new Listado();

            listado += cliente;
            listado += cliente2;

            Console.WriteLine(listado);

            Console.ReadLine();
        }
    }
}
