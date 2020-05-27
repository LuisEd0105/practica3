using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entero_division
{
    class Program
    {
        static void Main(string[] args)
        {
            /* programa que pide 2 numeros enteros donde si el 2do numero no es 0
             * se dividira con el 1ero, de lo contrario si el 2do es cero se escribira
             *  un error afirmando que no se puede dividir entre 0.
             */

            double n1;
            double n2;
            double reslt;

            Console.Write("\nDigite el numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                Console.Write("Digite el segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                reslt = n1 / n2;
                Console.WriteLine("\nEl resultado de la division es: " + reslt);
            }
            else
            {
                Console.WriteLine("Error no se puede dividir entre 0 ");
                Console.WriteLine("\nPresione enter para finalizar");
            }
            Console.ReadKey();

        }
    }
}
