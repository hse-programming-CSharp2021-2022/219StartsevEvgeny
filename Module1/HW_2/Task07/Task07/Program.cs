using System;

namespace Task07
{
    class Program
    {
        public static void ReturnParts(out double a, out double b, double n)
        {
            string[] parts = n.ToString().Split(".");
            a = double.Parse(parts[0]);
            b = double.Parse(parts[1]);

        }
        public static void ReturnSqrtAndSquare(out double a, out double b, double n)
        {
            if (n >= 0)
            {
                a = Math.Sqrt(n);
            }
            else
            {
                a = -1;
            }
            b = Math.Pow(n, 2);
        }

        static void Main(string[] args)
        {
            double n = Convert.ToDouble(Console.ReadLine());
            double wholePart, drobPart;
            double sqrt, square;
            ReturnParts(out wholePart, out drobPart, n);
            ReturnSqrtAndSquare(out sqrt, out square, n);
            Console.WriteLine(wholePart + " " + drobPart);
            Console.WriteLine(sqrt + " " + square);
        }
    }
}
