using System;

public partial class Program
{
    // Проверка входной даты на корректность.
    private static bool ValidateData(int day, int month, int year)
    {
        string error = "";
        try
        {
            DateTime dateTime = new DateTime(year, month, day);
        }
        catch (ArgumentOutOfRangeException e)
        {
            error = e.ToString();
        }
        if (error.Equals("") && year >= 1701 && year <= 1800)
        {
            return true;
        }
        return false;
    }

    // Получение дня недели по дате.
    private static int GetDayOfWeek(int day, int month, int year)
    {
        DateTime dateTime = new DateTime(year, month, day);
        string dayName = dateTime.DayOfWeek.ToString();
        switch (dayName)
        {
            case "Monday":
                return 1;
            case "Tuesday":
                return 2;
            case "Wednesday":
                return 3;
            case "Thursday":
                return 4;
            case "Friday":
                return 5;
            case "Saturday":
                return 6;
            case "Sunday":
                return 7;
            default:
                return -1;
        }
    }

    // Получение даты пятницы.
    private static string GetDateOfFriday(int dateOfWeek, int day, int month, int year)
    {
        DateTime dateTime = new DateTime(year, month, day);
        while (dateOfWeek != 5)
        {
            dateTime = dateTime.AddDays(1);
            if (dateOfWeek == 7)
            {
                dateOfWeek = 1;
            }
            else
            {
                dateOfWeek++;
            }
        }
        return dateTime.ToString("dd.MM.yyyy");

    }
}