using System;

namespace Task01
{
    class Program
    {
        public static bool G(double x, double y)
        {
            if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 4)
            {
                if (y <= Math.Sqrt(2) && y >= -2)
                {
                    if (x >= 0 && x <= 2)
                    {
                        if (x >= y)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(G(1, 1));
        }
    }
}
