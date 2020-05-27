using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entero_positivo_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Ingrese el primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 >= 0)
            {
                if (n2 >= 0)
                Console.WriteLine("\nAmbos son positivos");
            }
            else
            {
                if(n2 < 0)
                Console.WriteLine("\nAmbos son es negativos");
            }

            if (n1 >= 0)
            {
                if (n2 < 0)
                Console.WriteLine("\nUno de ellos es negativo");
            }
            else
            {
                if (n1 < 0)
            {
                if (n2 >= 0)
                Console.WriteLine("\nUno de ellos es positivo");
            }

            }
                Console.ReadKey();

        }
    }
}
