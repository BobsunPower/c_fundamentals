using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace x02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rgx = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string num = Console.ReadLine();
            MatchCollection matches = Regex.Matches(num, rgx);
            string[] res = matches .Cast<Match>() .Select(a => a.Value.Trim()) .ToArray();
            Console.WriteLine(string.Join(", ", res));
        }
    }
}
