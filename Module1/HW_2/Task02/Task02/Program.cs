using System;

namespace Task02
{
    class Program
    {
        public static int GetMaxNum(int num)
        {
            if (num >= 100 && num <= 999)
            {
                int maxChar = -1, minChar = 10, midChar = 0, sum = 0;
                while (num != 0)
                {
                    int curNum = num % 10;
                    sum += curNum;
                    if (curNum >= maxChar)
                    {
                        maxChar = curNum;
                    }
                    if (curNum <= minChar)
                    {
                        minChar = curNum;
                    }
                    num /= 10;
                }
                midChar = sum - maxChar - minChar;
                return maxChar * 100 + midChar * 10 + minChar;
            }
            return 0;
        }
        public static void Main(string[] args)
        {
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetMaxNum(P));
        }
    }
}
