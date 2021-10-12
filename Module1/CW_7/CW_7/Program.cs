using System;

namespace CW_7
{
    class Program
    {
        public static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }

            
        }
        static void Main(string[] args)
        {


            
            Random random = new();
            int n = int.Parse(Console.ReadLine());
            int[][] arrays = new int[n][];
            for (int i = 0; i < n; i++)
            {
                arrays[i] = new int[random.Next(5, 16)];
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    arrays[i][j] = random.Next(-10, 11);
                }
            }
            Array.Sort(arrays, (x, y) => x.Length.CompareTo(y.Length));
            Array.ForEach(arrays, array =>
            {
                Array.Sort(array);
            });
            PrintArray(arrays);
            
            
            Random random = new();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1000, 10000);
            }
            PrintArray(arr);
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 10 == arr[i] / 1000)
                {
                    if ((arr[i] / 10) % 10 == (arr[i] / 100) % 10)
                    {
                        Console.WriteLine("Palindrome " + arr[i]);
                    }
                }
            }
            Console.WriteLine();
            int[] arr2 = Array.FindAll(arr, value => (value % 10 == value / 1000) && ((value / 10) % 10 == (value / 100) % 10));
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            
        }
    }
}
