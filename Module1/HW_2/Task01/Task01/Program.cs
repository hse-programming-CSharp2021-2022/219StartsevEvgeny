using System;

namespace Task01
{
    class Program
    {
        public static double CountPolinome(double x)
        {
            return x * (12 * x * x * x + 9 * x * x - 3 * x + 2) - 4;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(CountPolinome(Convert.ToDouble(Console.ReadLine())));
        }
    }
}
