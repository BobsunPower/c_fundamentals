using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace x04.StarEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                string encMsg = Console.ReadLine();
                string decMsg = DecryptMessage(encMsg);
                string rgx = @"\@(?<planet>[A-Za-z]+)+[^\@\-\!\:]*?\:(?<population>[0-9]+)+[^\@\-\!\:]*?\!(?<attackType>[A|D]{1})\![^\@\-\!\:]*?\-\>(?<count>[0-9]+)0";
                Match match = Regex.Match(decMsg, rgx);
                if (match.Success)
                {string planet = match.Groups["planet"].Value; string atkType = match.Groups["attackType"].Value;
                    if (atkType == "A")
                    {attacked.Add(planet);}
                    else if (atkType == "D")
                    {destroyed.Add(planet);}}}
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var planet in attacked.OrderBy(n => n))
            {Console.WriteLine($"-> {planet}");}
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(n => n))
            {Console.WriteLine($"-> {planet}");}
        }
        static int DecryptionCount(string encMsg)
        {
            string decPtn = @"[star]{1}";
            MatchCollection matches = Regex.Matches(encMsg, decPtn, RegexOptions.IgnoreCase);
            return matches.Count;
        }
        static string DecryptMessage(string encMsg)
        {
            int matches = DecryptionCount(encMsg);
            StringBuilder decMsg = new StringBuilder();
            foreach (char ch in encMsg)
            {char chr = ch; chr -= (char)matches; decMsg.Append(chr);}
            return decMsg.ToString();
        }
    }
}
