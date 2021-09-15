using System;

namespace Task02
{
    class Program
    {
        public static double G(double x, double y)
        {
            if (x < y && x > 0)
            {
                return x + Math.Sin(y);
            }

            else if (x > y && x < 0)
            {
                return y - Math.Cos(x);
            }
            return 0.5 * x * y; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(G(5, 3));
        }
    }
}
