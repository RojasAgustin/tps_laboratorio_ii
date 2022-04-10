using System;
using Entidades;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando obj1 = new Operando();
            Operando obj2 = new Operando(12);

            Console.WriteLine(obj2.BinarioDecimal("44"));
            Console.ReadKey();
        }
    }
}
