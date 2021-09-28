using System;

namespace Task02
{
    class Program
    {
        public static bool Shift(ref char ch)
        {
            int n = Convert.ToInt32(ch);
            // 97-122
            for (int i = 0; i < 4; i++)
            {
                if (n >= 122)
                {
                    ch = '-';
                    return false;
                }
                n += 1;
            }
            ch = Convert.ToChar(n);
            return true;
        }
            
        static void Main(string[] args)
        {
            // Программа работает только для маленьких букв.

            char ch = char.Parse("v");
            bool flag = Shift(ref ch);
            if (flag)
            {
                Console.WriteLine(ch);
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
    }
}
