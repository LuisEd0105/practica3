using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplo_4_y_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int reslt;
            int reslt2;

            Console.Write("ingrese el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            reslt = numero % 4;
            reslt2 = numero % 5;

                if (reslt == reslt2)
                {
                    Console.WriteLine("Es multiplo de ambos");
                }
                else
                {

                    if (reslt == 0)
                    {
                        Console.WriteLine("\n" + numero + " Es multiplo de 4");
                    }
                    else
                    {
                        Console.WriteLine("\n" + numero + " no es multiplo de 4");
                    }
                    if (reslt2 == 0)
                    {
                        Console.WriteLine("\n" + numero + " Es multiplo de 5");
                    }
                    else
                    {
                        Console.WriteLine("\n" + numero + " No es multiplo de 5");
                    }
                }
                Console.ReadKey();
            }
        }
    }