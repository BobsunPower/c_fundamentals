using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace x02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = @"[A-Za-z]+";
            string nums = @"(?<numbers>[0-9])";
            Dictionary<string, int> rnk = new Dictionary<string, int>();
            foreach (var name in Console.ReadLine().Split(", "))
            {rnk.Add(name, 0);}
            string cmd;
            while ((cmd = Console.ReadLine()) != "end of race"){
                MatchCollection matches = Regex.Matches(cmd, names);
                StringBuilder sb = new StringBuilder();
                foreach (Match letter in matches)
                {sb.Append(letter);}
                string name = sb.ToString();
                if (rnk.ContainsKey(name))
                {MatchCollection kms = Regex.Matches(cmd, nums);
                    foreach (Match k in kms)
                    {int cnt = int.Parse(k.Groups["numbers"].Value); rnk[name] += cnt;}}}
            Dictionary<string, int> wnrs = rnk.OrderByDescending(km => km.Value) .Take(3) .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine($"1st place: {wnrs.Keys.First()}");
            wnrs.Remove(wnrs.Keys.First());
            Console.WriteLine($"2nd place: {wnrs.Keys.First()}");
            wnrs.Remove(wnrs.Keys.First());
            Console.WriteLine($"3rd place: {wnrs.Keys.First()}");
        }
    }
}
