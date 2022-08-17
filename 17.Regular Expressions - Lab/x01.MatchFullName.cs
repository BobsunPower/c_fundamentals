using System;
using System.Text.RegularExpressions;

namespace x01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rgx = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();
            MatchCollection matches = Regex.Matches(names, rgx);
            foreach (Match match in matches)
            {Console.Write(match.Value + " ");}
            Console.WriteLine();
        }
    }
}
