using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enteros_multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que pide al usuario 2 numeros enteros y dice si el 1ro es multiplo del 2do//
            int n1, n2;
            Console.Write("Digite el primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite el segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 % n2 == 0)
            {
                Console.WriteLine(n1 + " es multiplo de " + n2);
            }
            else
            {
                Console.WriteLine(n1 + " no es multiplo de " + n2);
            }
            Console.ReadKey();


        }
    }
}
