using System;
using System.Globalization;

namespace Task06
{
    class Program
    {
        public static decimal CountBudget(decimal budget, int percent)
        {
            return (budget * percent) / 100;
        }
        static void Main(string[] args)
        {
            decimal budget = Convert.ToDecimal(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());
            // рубли
            Console.WriteLine(CountBudget(budget, percent).ToString("C3", CultureInfo.GetCultureInfo("ru")));
            
            // евро
            Console.WriteLine(CountBudget(budget, percent).ToString("C3", CultureInfo.GetCultureInfo("fr-FR")));
            
            // доллары
            Console.WriteLine(CountBudget(budget, percent).ToString("C3", CultureInfo.GetCultureInfo("en-US")));

        }
    }
}
