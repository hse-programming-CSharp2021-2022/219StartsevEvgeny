using System;

namespace Task05
{
    class Program
    {
        public static bool CheckTriangle(double a, double b, double c)
        {
            return a + b > c && b + c > a && a + c > b;
        }
        public static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CheckTriangle(A, B, C));
            
        }
    }
}
    