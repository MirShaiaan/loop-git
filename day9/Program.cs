using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day9
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine(" the range of prime ");

            Console.WriteLine(" the minimum range of prime numbers");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(" the maximum range of prime numbers");
            int max = int.Parse(Console.ReadLine());


            for (min = min; min <= max; min++)
            {
                int toy = 0;
                int b = 2;
                for (b = 2; b < min; b++)
                {
                    if (min % b == 0)
                    {
                        toy = 1;
                    }



                }
                if (toy == 1)
                {
                    Console.WriteLine(min + " COMPOSITE NUMBER ");
                }
                else
                {
                    Console.WriteLine(min + " PRIME NUMBER ");
                }
            }






            

















        }
    }
}
