using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code = Convert.ToInt32(Console.ReadLine()); // метод преобразования строк в целый тип
            Console.WriteLine(Convert.ToChar(Code)); // операция приведения типа
        }
    }
}
