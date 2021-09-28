using System;

namespace CW_5
{
    class Program
    {
        public static bool Transform (ref uint number)
        {
            uint a1 = 0;
            uint a2 = 0;
            uint a3 = 0;
            uint a4 = 0;
            uint a5 = 0;
            uint a6 = 0;
            uint a7 = 0;
            uint a8 = 0;
            uint a9 = 0;
            uint a0 = 0;
            uint count = 0;
            while (number != 0)
            {
                uint digit = number % 10;
                switch (digit)
                {
                    case 1:
                        a1 += 1;
                        break;
                    case 2:
                        a2 += 1;
                        break;
                    case 3:
                        a3 += 1;
                        break;
                    case 4:
                        a4 += 1;
                        break;
                    case 5:
                        a5 += 1;
                        break;
                    case 6:
                        a6 += 1;
                        break;
                    case 7:
                        a7 += 1;
                        break;
                    case 8:
                        a8 += 1;
                        break;
                    case 9:
                        a9 += 1;
                        break;
                    default:
                        a0 += 1;
                        break;
                }
                number /= 10;
                count++;

            }
            uint n = 1;
            for (uint i = 1; i < count; i++)
            {
                n *= 10;
            }

            for (uint i = 0; i < count; i++)
            {
                if (a9 != 0)
                {
                    number += 9 * n;
                    a9--;
                }
                else if (a8 != 0)
                {
                    number += 8 * n;
                    a8--;
                }
                else if (a7 != 0)
                {
                    number += 7 * n;
                    a7--;
                }
                else if (a6 != 0)
                {
                    number += 6 * n;
                    a6--;
                }
                else if (a5 != 0)
                {
                    number += 5 * n;
                    a5--;
                }
                else if (a4 != 0)
                {
                    number += 4 * n;
                    a4--;
                }
                else if (a3 != 0)
                {
                    number += 3 * n;
                    a3--;
                }
                else if (a2 != 0)
                {
                    number += 2 * n;
                    a2--;
                }
                else if (a1 != 0)
                {
                    number += 1 * n;
                    a1--;
                }
                else
                {
                    number += 0 * n;
                    a0--;
                }
                n /= 10;
            }
            return true;
        }

        public static bool Transform2(ref uint number) {

            uint[] digits = new uint[number.ToString().Length];
            for (uint i = 0; i < digits.Length; i++)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            Array.Sort(digits);
            uint n = 1;
            for (uint i = 1; i < digits.Length; i++)
            {
                n *= 10;
            }
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                number += digits[i] * n;
                n /= 10;
            }
            return true;
        }

        public static int[] MethodThree(int[] array)
        {
            int k = array.Length;
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine((array[i] + array[i - 1]) % 3 == 0);
                if ((array[i] + array[i - 1]) % 3 == 0)
                {
                    array[i - 1] = array[i] * array[i - 1];
                    Console.WriteLine(array[i - 1]);    
                    for (int j = i; j < k; j++)
                    {
                        if (j != k - 1)
                        {
                            array[j] = array[j + 1];
                        }
                    }
                    k--;
                }
                for (int a = 0; a < array.Length; a++)
                {
                    Console.Write(array[a] + " ");
                }
                Console.WriteLine("");
            }
            int[] answer = new int[k];
            for (int i = 0; i < k; i++)
            {
                answer[i] = array[i];
            }
            return answer;
        }

        public static int[] MethodFour(int[] array)
        {
            int k = array.Length;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    for (int j = i; j < k; j++)
                    {
                        if (j != k - 1)
                        {
                            array[j] = array[j + 1];
                        }
                    }
                    k--;
                }
            }
            return array; // метод незакончен
        }
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            string[] input = Console.ReadLine().Split();
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            int[] a = MethodThree(array);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            /*
            uint number = uint.Parse(Console.ReadLine());
            bool flag = Transform2(ref number);
            Console.WriteLine(number);
            */
        }
    }
}
