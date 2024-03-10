using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerDowhile1inclas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            do
            {
                Console.WriteLine(" ingrese numero ");
                num = int.Parse(Console.ReadLine());

                if (num < 10)
                {
                    Console.WriteLine(" el numero es de una cifra");
                }
                else if (num < 100)
                {
                    Console.WriteLine(" el numero es de dos cifras ");
                }

                else

                {
                    Console.WriteLine(" el numero es de tres cifras ");
                }
            }

                    while (num <= 100);

                    Console.ReadKey();
            
        }
    }
}
