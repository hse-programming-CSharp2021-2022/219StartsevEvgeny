using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            double a, b;
            bool flag1 = double.TryParse(s1, out a); // проверка на введение числа
            bool flag2 = double.TryParse(s2, out b);
            if (flag1 && flag2)
            {
                double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)); // теорема Пифагора
                Console.WriteLine(c);
            }
        }
    }
}
