using System;

namespace Task04
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            string num3 = Console.ReadLine();
            int max = -1;
            string maxAud;
            if (int.Parse(num1[1].ToString() + num1[2].ToString()) > max)
            {
                if (num1[1] != 0)
                {
                    max = int.Parse(num1[1].ToString() + num1[2].ToString());
                    maxAud = num1;
                }
                else
                {
                    max = int.Parse(num1[2].ToString());
                    maxAud = num1;
                }
                
            }
            if (int.Parse(num2[1].ToString() + num2[2].ToString()) > max)
            {
                if (num2[1] != 0)
                {
                    max = int.Parse(num2[1].ToString() + num2[2].ToString());
                    maxAud = num2;
                }
                else
                {
                    max = int.Parse(num2[2].ToString());
                    maxAud = num2;
                }
            }
            if (int.Parse(num3[1].ToString() + num3[2].ToString()) > max)
            {
                if (num3[1] != 0)
                {
                    max = int.Parse(num3[1].ToString() + num3[2].ToString());
                    maxAud = num3;
                }
                else
                {
                    max = int.Parse(num3[2].ToString());
                    maxAud = num3;
                }
            }
            Console.WriteLine(num3);

        }
    }
}
