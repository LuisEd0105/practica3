using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entero_par
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que le pida al usuario un numero entero y diga si es par //
            int num = 0;
            Console.Write("Digite un numero: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero no es par");
            }
            Console.WriteLine("\nPresione enter para finalizar");
            Console.ReadKey();
        }
    }
}
