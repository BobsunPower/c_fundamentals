using System;
using System.Text.RegularExpressions;

namespace x03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rgx = @"\b(?<day>\d{2})(.|-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matches = Regex.Matches(dates, rgx);
            foreach (Match m in matches)
            {string day = m.Groups["day"].Value; string month = m.Groups["month"].Value; string year = m.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");}
        }
    }
}
