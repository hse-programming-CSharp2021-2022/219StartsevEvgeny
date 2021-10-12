using System;

namespace CW_6
{

    class Program
    {
        public static void PrintArray(int[] array)
        {
            foreach (int el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            Random random = new();
            int[] array = new int[99];
            for (int i = 0; i < 99; i++)
            {
                int n = random.Next(1, 101);
                int index = random.Next(0, 99);

                
            }
            PrintArray(array);
            for (int x = 1; x <= 100; x++)
            {
                if (!Array.Exists(array, value => value == x))
                {
                    Console.WriteLine(x);
                    break;
                }
            }
        }
    }
}


    /*
    class Program
    {
        public static void PrintArray(char[] array)
        {
            foreach (char el in array)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            char[] array = new char[k];
            Random random = new();
            for (int i = 0; i < k; i++)
            {
                array[i] = (char)random.Next('A', 'Z' + 1);
            }

            Console.WriteLine("Basic array");
            PrintArray(array);

            char[] array2 = new char[k];
            Array.Copy(array, array2, k);

            Array.Sort(array);
            Console.WriteLine("Sorted array");
            PrintArray(array);

            Array.Reverse(array);
            Console.WriteLine("Reversed array");
            PrintArray(array);
        }
    }
    */

