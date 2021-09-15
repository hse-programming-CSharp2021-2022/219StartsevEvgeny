using System;

namespace Task04
{
    class Program
    {
        public static void Reverse(out int a, out int b, out int c, out int d, int n)
        {
            a = n / 1000;
            b = n / 100 % 10;
            c = n / 10 % 10;
            d = n % 10;
        }
        public static void Main(string[] args)
        {
            int a, b, c, d;
            int n = Convert.ToInt32(Console.ReadLine());
            Reverse(out a, out b, out c, out d, n);
            Console.WriteLine(d * 1000 + c * 100 + b * 10 + a);
        }
    }
}
