using System;

namespace Task03
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            return Math.Sin(((x - 1) / 2) * Math.PI); 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(G(6).ToString("F4"));
            Console.WriteLine(G(-1));
        }
    }
}
