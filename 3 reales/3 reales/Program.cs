using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_reales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que pide 3 numeros reales y dice cual es el mayor de los 3//
            int n1, n2, n3;
            Console.Write("Ingrese el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el primer numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el primer numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("\n"+ n1 +" Es el numero mayor");
                }
            }
            if (n2 > n1)
            {
                if (n2 > n3)
                {
                    Console.WriteLine("\n" + n2 + " Es el numero mayor");
                }
            }
            if (n3 > n1)
            {
                if (n3 > n1)
                {
                    Console.WriteLine("\n" + n3 + " Es el numero mayor");
                }
            }
            Console.ReadKey();


        }
    }
}
