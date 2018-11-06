using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            AllPrimes(num);
        }

        static void AllPrimes(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                
                if (IsPrime(i))
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
