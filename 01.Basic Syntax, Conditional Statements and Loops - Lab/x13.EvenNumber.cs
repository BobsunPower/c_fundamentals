using System;
using System.Globalization;

namespace x13.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            var end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture); var holidays = 0;
            for (var date = start; date <= end; date = date.AddDays(1))
            {if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) holidays++;}
            Console.WriteLine(holidays);
        }
    }
}
