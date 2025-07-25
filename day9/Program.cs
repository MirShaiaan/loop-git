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
            //// done by shaiaan -- for loop on 25/07/2025 at 3:30pm

            //done some changes too

            //Console.WriteLine(" the range of prime ");

            //Console.WriteLine(" the minimum range of prime numbers");
            //int min = int.Parse(Console.ReadLine());
            //Console.WriteLine(" the maximum range of prime numbers");
            //int max = int.Parse(Console.ReadLine());


            //for (int i = min; min <= max; min++)
            //{
            //    int flag = 0;               //0 means prime
            //    for (int b = 2; b < min; b++)
            //    {
            //        if (min % b == 0)
            //        {
            //            flag = 1;
            //        }


            //    }
            //    if (flag == 1)
            //    {
            //        Console.WriteLine(min + " COMPOSITE NUMBER.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(min + " PRIME NUMBER.");
            //    }
            //}



            // range of prime done by faizan ----- 25/07/2025 at 3:54pm.


            Console.WriteLine("======Range of prime using while loop======");

            Console.Write("Enter the minimum value: ");
            int min2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the maximum value: ");
            int max2 = int.Parse(Console.ReadLine());

            while(min2 <= max2)
            {
                int flag = 0;
                int i = 2;
                while(i < min2)
                {
                    if(min2 % i == 0)
                    {
                        flag = 1;
                    }
                    i++;
                }

                if(flag == 1)
                {
                    Console.WriteLine($"{min2} is composite!");
                }
                else
                {
                    Console.WriteLine($"{min2} is prime!");
                }
                min2++;
            }
        }
    }
}
