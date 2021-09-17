using System;

namespace CW_3
{
    class Program
    {
        public static int[] FindNumsWithThreeDividers(int start, int end, int k)
        {
            int[] nums = new int[1000];
            int index = 0;
            for (int n = start; n <= end; n++)
            {
                int count = 0;
                for (int j = 1; j <= (int)Math.Sqrt(n); j++)
                {
                    if (n % j == 0)
                    {
                        if (j != n / j)
                        {
                            count += 1;
                        }
                        else
                        {
                            count += 2;
                        }
                        if (count > k)
                        {
                            break;
                        }
                    }
                }
                if (count == k)
                {
                    nums[index] = n;
                    index++;
                }
            }
            return nums;
        }
        
        public static double TotalCommon(double k, double r, uint n)
        {
            double final = k;
            for (int i = 0; i < n; i++)
            {
                final *= (1 + r / 100);
            }
            return final; 
        }
        public static double TotalRecursion(double k, double r, uint n)
        {
            double final = k;
            for (int i = 0; i < n; i++)
            {
                final += TotalCommon(k, r, 1);
            }
            return final;
        }
        public static double F(double x)
        {
            return x * x;
        }
        public static int A(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return A(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return A(m - 1, A(m, n - 1));
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TotalCommon(100, 10, 1));
            //A(5, 2);
            /*double a = Convert.ToInt32(Console.ReadLine());
            double b = Convert.ToInt32(Console.ReadLine());
            double delta = Convert.ToInt32(Console.ReadLine());
            double answer = 0;
            for (int i = 0; i < (Math.Abs(b - a)) / delta; i++)
            {
                double S = ((F(a) + F(a + delta)) * delta) / 2;
                answer += S;
                a += delta;
            }
            Console.WriteLine(answer.ToString("F5"));
            */

            /*
            bool flag = true;
            double a = 1, b = 2, c = 3;
            double sum = 0;
            double past = 0;
            double current = 1;
            while (current > past)
            {
                current = 1 / (a * b * c);
                sum += current;
                if (past >= current)
                {
                    flag = false;
                    break;
                }
                past = current;
                a += 1;
                b += 1;
                c += 1;
                Console.WriteLine(sum);
            }
            Console.WriteLine(sum.ToString("F30"));*/

        }
    }
}
