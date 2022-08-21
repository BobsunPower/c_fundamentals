using System;
using System.Text.RegularExpressions;

namespace x06.ExtractEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            string rgx = @"(?<=\s|^)[a-z0-9]+[\.\-_a-z0-9]+@[a-z\-]+\.([\.A-Za-z]+)+\b";
            MatchCollection matches = Regex.Matches(cmd, rgx);
            foreach (Match match in matches)
            {Console.WriteLine(match);}
        }
    }
}
