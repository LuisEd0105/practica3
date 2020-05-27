using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*programa que dira si el 1er numero es multiplo de 10, se informara al usuario si es o no
             y luego se le pedira al usuario digitar otro numero para tambien saber si es o no es
             multiplo de 10*/
            int num;
            int num2;
            int reslt;

            Console.Write("\nDigite el numero: ");
            num = int.Parse(Console.ReadLine());
            reslt = num % 10;

            if (reslt == 0)
            {
                Console.WriteLine("\n"+ num + " es multiplo de 10");
                Console.Write("\nDigite el segundo numero: ");
                num2 = int.Parse(Console.ReadLine());
                reslt = num2 % 10;
            }
            else
            {
                Console.WriteLine("\nEl numero no es multiplo de 10");
                Console.WriteLine("\nPresione enter para finalizar");
            }
            if (reslt == 0)
            {
                Console.WriteLine("\nTambien es multiplo de 10");
                Console.WriteLine("\nPresione enter para finalizar");
            }
            else
            {
                Console.WriteLine("\nEste no es multiplo de 10");
            }
            Console.ReadKey();
        }
    }
}
