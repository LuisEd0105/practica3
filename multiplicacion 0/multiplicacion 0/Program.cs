using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacion_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa donde el usuario digitara un 1er numero, si teclea 0 dara un mensaje 
             de advertencia pero si se ha tecleado otro se pedira el producto
               de ambos.
             */
            int n1;
            int n2;
            int reslt;

            Console.Write("\nDigite el numero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                Console.Write("Digite el segundo numero: ");
                n2 = int.Parse(Console.ReadLine());
                reslt = n1 * n2;
                Console.WriteLine("\nEl resultado del producto es: " + reslt);
            }
            else
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0");
                Console.WriteLine("\nPresione enter para finalizar");
            }
            Console.ReadKey();
        }
    }
}
