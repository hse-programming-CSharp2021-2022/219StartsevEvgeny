using System;

namespace Task03
{
    class Program
    {
        public static dynamic CountRoots(double A, double B, double C)
        {
            dynamic D = A == 0 ? null : Math.Pow(B, 2) - 4 * A * C;

            switch (D)
            {
                case null:
                    dynamic n = B != 0 ? -C / B : "Infinite number of solutions or no solutions";
                    return n;
                case < 0:
                    return "No solutions";
                case > 0:
                    double x1 = (-B - Math.Sqrt(D)) / (2 * A);
                    double x2 = (-B + Math.Sqrt(D)) / (2 * A);
                    return $"{x1}, {x2}";
                case 0:
                    double x = -B / 2 * A;
                    return x;
                default:
                    return "Something went wrong";
            }
        }
        public static void Main(string[] args)
        {
            double A = Convert.ToInt32(Console.ReadLine());
            double B = Convert.ToInt32(Console.ReadLine());
            double C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CountRoots(A, B, C));

        }
    }
}
