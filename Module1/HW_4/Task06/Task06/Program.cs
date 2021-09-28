using System;

namespace Task06
{
    class Program
    {
        public static double Factorial(int n)
        {
            double ans = 1;
            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    ans *= i;
                }
            }
            return ans;
        }
        public static double S1(double x)
        {
            double s = x * x;
            int n = 3;
            int m = -1;
            while (s <= s + (Math.Pow(2, n) * Math.Pow(x, n + 1)) / Factorial(n + 1))
            {
                s += m * (Math.Pow(2, n) * Math.Pow(x, n + 1)) / Factorial(n + 1);
                n += 2;
                m *= -1;
            }
            return s;

        }
        public static double S2(double x)
        {
            double s = 1;
            int n = 3;
            while (s <= s + Math.Pow(x, n) / Factorial(n))
            {
                s += Math.Pow(x, n) / Factorial(n);
                n += 1;
            }
            return s;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(S1(3).ToString("F30"));
            Console.WriteLine(S2(3).ToString("F30"));
        }
    }
}
