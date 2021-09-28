using System;

namespace Task07
{
    class Program
    {
        public static int GCD(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                if (a > b)
                {
                    return GCD(a % b, b);
                }
                else
                {
                    return GCD(b, a % b);
                }
            }
        }

        public static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        static void Main(string[] args)
        {
            int a = 12;
            int b = 32;
            int gcd = GCD(a, b);
            int lcm = LCM(a, b);
            Console.WriteLine(gcd + " " + lcm);
        }
    }
}
