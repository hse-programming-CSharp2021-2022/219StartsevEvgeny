using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            double U, R;
            bool flag1 = double.TryParse(s1, out U); // проверка на введение числа
            bool flag2 = double.TryParse(s1, out R);
            if (flag1 && flag2)
            {
                double I = U / R; // сила тока
                //Console.WriteLine(I);
                double P = (Math.Pow(U, 2)) / R; // потребляемая мощность 
                //Console.WriteLine(P);
            }

        }
    }
}
