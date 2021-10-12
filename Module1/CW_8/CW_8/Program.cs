using System;
using System.Text;

namespace CW_8
{
    class Program
    {
        public static void GenerateAbbreviations()
        {
            string[] symbols = Console.ReadLine().Trim().Split(';');
            foreach (string element in symbols)
            {
                StringBuilder stringBuilder = new();
                bool isFirstLetter = true;
                bool isFirstAEIOUY = false;
                foreach (char letter in element)
                {
                    if ((letter == 65 || letter == 69 || letter == 73 || letter == 79 || letter == 85 || letter == 89
                        || letter == 97 || letter == 101 || letter == 105 || letter == 111 || letter == 117 || letter == 121) && !isFirstAEIOUY)
                    {
                        if (isFirstLetter)
                        {
                            isFirstLetter = false;
                            stringBuilder.Append(letter.ToString().ToUpper());
                        }
                        else
                        {
                            stringBuilder.Append(letter);
                        }
                        isFirstAEIOUY = true;
                    }
                    else if (letter != 32 && !isFirstAEIOUY)
                    {

                        if (isFirstLetter)
                        {
                            stringBuilder.Append(letter.ToString().ToUpper());
                            isFirstLetter = false;
                        }
                        else
                        {
                            stringBuilder.Append(letter);
                        }
                    }
                    else if (letter == 32)
                    {
                        isFirstLetter = true;
                        isFirstAEIOUY = false;
                    }
                }
                Console.WriteLine(stringBuilder.ToString());
            }
        }

        public static string ConvertHex2Bin(string HexNumber)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char element in HexNumber)
            {
                switch (element)
                {
                    case '0':
                        sb.Append("0000");
                        break;
                    case '1':
                        sb.Append("0001");
                        break;
                    case '2':
                        sb.Append("0010");
                        break;
                    case '3':
                        sb.Append("0011");
                        break;
                    case '4':
                        sb.Append("0100");
                        break;
                    case '5':
                        sb.Append("0101");
                        break;
                    case '6':
                        sb.Append("0110");
                        break;
                    case '7':
                        sb.Append("0111");
                        break;
                    case '8':
                        sb.Append("1000");
                        break;
                    case '9':
                        sb.Append("1001");
                        break;
                    case 'A':
                        sb.Append("1010");
                        break;
                    case 'B':
                        sb.Append("1011");
                        break;
                    case 'C':
                        sb.Append("1100");
                        break;
                    case 'D':
                        sb.Append("1101");
                        break;
                    case 'E':
                        sb.Append("1110");
                        break;
                    case 'F':
                        sb.Append("1111");
                        break;
                }
            }
            return sb.ToString();
        }

        public static void Task1()
        {
            string[] input = Console.ReadLine().Trim().Split();
            string[] newInput = new string[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i].Trim();
                newInput[i] = input[i];
            }
            for (int i = 0; i < newInput.Length; i++)
            {
                Console.Write(newInput[i] + " ");
            }
        }

        public static void Task2()
        {
            string input = Console.ReadLine();
            string[] words = new string[input.Split().Length];
            StringBuilder word = new StringBuilder();
            int index = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 32)
                {
                    word.Append(input[i]);
                }
                else
                {
                    words[index] = word.ToString();
                    index++;
                    word = new StringBuilder();
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }
        }

        public static void Task3()
        {
            string[] input = Console.ReadLine().Trim().Split();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length != 0)
                {
                    char letter = input[i][0];
                    if ((letter == 65 || letter == 69 || letter == 73 || letter == 79 || letter == 85 || letter == 89
                    || letter == 97 || letter == 101 || letter == 105 || letter == 111 || letter == 117 || letter == 121))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }

        static void Main(string[] args)
        {
            Task3();
        }
    }
}
