using System;
using System.Text.RegularExpressions;

namespace x03.SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rgx = @"\%(?<name>[A-Z]{1}[a-z]+)\%[^|$%.]*?\<(?<product>\w+)\>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(?:\.\d+)?)\$";
            string cmd; decimal inc = 0;
            while ((cmd = Console.ReadLine()) != "end of shift") {
                MatchCollection matches = Regex.Matches(cmd, rgx);
                foreach (Match match in matches) {
                    string name = match.Groups["name"].Value; string pdt = match.Groups["product"].Value;
                    int cnt = int.Parse(match.Groups["count"].Value);
                    double prc = double.Parse(match.Groups["price"].Value);
                    Console.WriteLine($"{name}: {pdt} - {cnt * prc:f2}");
                    inc += (decimal)prc * cnt;}}
            Console.WriteLine($"Total income: {inc:f2}");
        }
    }
}
