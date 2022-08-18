using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace x01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rgx = @">>(?<product>[A-Z]([A-Z]+|[a-z]+))<<(?<price>([0-9]+[.|\][0-9]+))!(?<quantity>\d+)\b"; 
            string data = Console.ReadLine();
            List<string> fnt = new List<string>();
            double tot = 0;
            while (data != "Purchase") {
                MatchCollection matches = Regex.Matches(data, rgx);
                foreach (Match m in matches) {
                    tot += double.Parse(m.Groups["price"].Value) * int.Parse(m.Groups["quantity"].Value);
                    fnt.Add(m.Groups["product"].Value);}
                data = Console.ReadLine();}
            Console.WriteLine("Bought furniture:");
            if (fnt.Count > 0)
            {Console.WriteLine(string.Join(Environment.NewLine, fnt));}
            Console.WriteLine($"Total money spend: {tot:f2}");
        }
    }
}
