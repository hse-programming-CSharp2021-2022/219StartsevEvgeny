using System;

namespace CW_9
{
    class Program
    {
        static string DigitToString(int digit)
        {
            string[] digitString = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            switch(digit)
            {
                case 0:
                    return digitString[0];
                case 1:
                    return digitString[1];
                case 2:
                    return digitString[2];
                case 3:
                    return digitString[3];
                case 4:
                    return digitString[4];
                case 5:
                    return digitString[5];
                case 6:
                    return digitString[6];
                case 7:
                    return digitString[7];
                case 8:
                    return digitString[8];
                case 9:
                    return digitString[9];
            }
            return digitString[digit];
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int n;
            int per;

            do
            {
                Console.WriteLine("Введите размер массива: ");
            } while (!int.TryParse(Console.ReadLine(), out n) && n > 1);

            do
            {
                Console.WriteLine("Введите количество процентов: ");
            } while (!int.TryParse(Console.ReadLine(), out per) && per >= 0);

            string[] arr = new string[n];

            int letterAmount = (int)(n * per / 100.0);

            Random random = new();
            for (int i = 0; i < letterAmount; i++)
            {
                arr[i] = ((char)random.Next('a', 'z' + 1)).ToString();
            }
            for (int i = letterAmount; i < n; i++)
            {
                arr[i] = DigitToString(random.Next(0, 10));
            }

            Array.ForEach(arr, x => Console.Write(x + " "));
        }
    }
}
