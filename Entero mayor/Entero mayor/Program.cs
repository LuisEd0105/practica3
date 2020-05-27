using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entero_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que pedira al usuario 2 numeros enteros y dira cual es el mayor de ellos//
            int n1;
            int n2;
            Console.Write("Digite el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (n1 > n2)
            {
                Console.WriteLine(n1 + " es el mayor");
            }
            else
            {
                Console.WriteLine(n2 + " es el mayor");
            }
            Console.WriteLine("\nPresione enter para finalizar");
            Console.ReadKey();
        }
    }
}
