using System;
using System.Linq;

namespace CW_10
{
    class Program
    {
        public static int NumSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static bool Palindrome(int num)
        {
            string n = num.ToString();
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (!n[i].Equals(n[n.Length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }

        public static int MaxDigit(int num)
        {
            int maxDigit = -1;
            while (num != 0)
            {
                int digit = num % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    if (maxDigit == 9)
                    {
                        return maxDigit;
                    }
                }
                num /= 10;
            }
            return maxDigit;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Random random = new();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(1, 10001);
            }

            var a1 = from t in array
                     where t % 3 == 0
                     where t >= 10
                     where t <= 99
                     select t;

            foreach (var el in a1)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            var a2 = from t in array
                     where Palindrome(t)
                     orderby t
                     select t;
            
            foreach (var el in a2)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();

            var a3 = array.OrderBy(element => NumSum(element)).ThenBy(element => element);

            foreach (var el in a3)
            {
                Console.Write(el + " ");
            }

            var a4 = (from t in array
                     where t >= 1000
                     where t <= 9999
                     select t).ToArray().Sum();

            Console.WriteLine(a4);

            var a5 = (from t in array
                      where t >= 10
                      where t <= 99
                      select t).ToArray().Min();

            Console.WriteLine(a5);

            var a6 = from t in array
                     select MaxDigit(t);

        }
    }
}
