using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            PrintAll(num1, num2);
        }
        static void PrintAll(int num1, int num2)
        {
            Console.WriteLine("Choose an option :");
            Console.WriteLine("1.Sum");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.WriteLine("");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine(Sum(num1, num2));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(Sub(num1, num2));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(Mul(num1, num2));
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(Div(num1, num2));
                        break;
                    }
                default:
                    {
                        break;
                    }

            }

        }

        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static int Sub(int num1, int num2)
        {
            int sub = num1 - num2;
            return sub;
        }
        static int Mul(int num1, int num2)
        {
            int mul = num1 * num2;
            return mul;
        }
        static int Div(int num1, int num2)
        {
            int div = num1 / num2;
            return div;
        }
    }
}
