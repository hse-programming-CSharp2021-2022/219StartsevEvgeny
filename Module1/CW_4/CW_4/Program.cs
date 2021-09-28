using System;

namespace CW_4
{
    class Program
    {
        public static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            string digits = "";
            while (number != 0)
            {
                digits += (number % 10).ToString();
                number /= 10;
            }
            for (int i = 0; i < digits.Length; i++)
            {
                if (uint.Parse(digits[i].ToString()) % 2 == 0)
                {
                    sumEven += uint.Parse(digits[i].ToString());
                }
                else
                {
                    sumOdd += uint.Parse(digits[i].ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            byte a = 20;
            byte b = 25;
            byte c = (byte)(a + b);
            Console.WriteLine(c);
            
            Console.WriteLine(a ^ b);
            uint sumEven;
            uint sumOdd;
            Sums(1234, out sumEven, out sumOdd);
            Console.WriteLine(sumOdd + " " + sumEven);
        }
    }
}
