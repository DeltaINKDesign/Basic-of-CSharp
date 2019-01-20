using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Time
{
    public class Program
    {
        public static void Main()
        {
            DateTime uro = new DateTime(1997, 11, 1);
            DateTime data1 = new DateTime(2019, 1, 1);
            Console.WriteLine("Dzisiaj jest " + DateTime.Now
                             + " \n100 dni temu był " + DateTime.Now.AddDays(-100).DayOfWeek
                             + " \n1 styczen wypada " + data1.DayOfWeek
                             + " \nza 2 godziny i 55 minut będzie " + DateTime.Now.AddMinutes(175)
                             + " \nCzy za 3000 dni temu rok byl przestepny? " + DateTime.IsLeapYear(DateTime.Now.AddDays(3000).Year)
                             + " \nBiezacy miesiac liczy " + DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)
                             + " \nOd mojej daty urodzenie mineło: " + (DateTime.Today - uro).TotalDays);
            Console.WriteLine("\nPODAJ PARAMETR");
            DateTime para = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("\nData po naszej podanej dacie: " + Klasa.GetNextDay(para) + "\nJutrzejsza data: " + Klasa.GetTomorrow() + "\nData przed naszą datą: " + Klasa.GetPreviousDay(para) + "\nWczorajsza data: " + Klasa.GetYesterday() + "\nNajbliższa niedziela: " + Klasa.GetNextSunday(para));
        }
    }
    public static class Klasa
    {
        public static DateTime GetNextDay(DateTime parametr)
        {
            return parametr.AddDays(1);

        }
        public static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        public static DateTime GetPreviousDay(DateTime parametr)
        {
            return parametr.AddDays(-1);
        }
        public static DateTime GetYesterday()
        {
            return DateTime.Today.AddDays(-1);
        }
        public static DateTime GetNextSunday(DateTime parametr)
        {
            int i = 0;
            while (parametr.AddDays(i).DayOfWeek.ToString() != "Sunday")
            {
                i++;
            }
            return parametr.AddDays(i);
        }
    }

}

