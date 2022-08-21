using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace x05.NetherRealms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Demon> dmnBook = new SortedDictionary<string, Demon>();
            string[] dmn = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string d in dmn)
            {dmnBook.Add(d, new Demon(GetDemonHealth(d), GetDemonDamage(d)));}
            foreach (KeyValuePair<string, Demon> kvp in dmnBook)
            {Console.WriteLine($"{kvp.Key} - {kvp.Value.hlt} health, {kvp.Value.dmg:f2} damage");}
        }
        class Demon
        {
            public Demon(int hlt, double dmg)
            {this.hlt = hlt; this.dmg = dmg;}
            public int hlt {get; set;}
            public double dmg {get; set;}
        }
        static int GetDemonHealth(string dmn)
        {
            int hlt = 0;
            foreach (char ch in dmn) {
                if (!char.IsDigit(ch) && ch != '+' && ch != '-' && ch != '*' && ch != '/' && ch != '.')
                {hlt += ch;}}
            return hlt;
        }
        static double GetDemonDamage(string dmn)
        {
            string numPtn = @"-?\d+\.?\d*"; string oprPtn = @"[*/]";
            MatchCollection numMatches = Regex.Matches(dmn, numPtn);
            MatchCollection oprMatches = Regex.Matches(dmn, oprPtn);
            double dmg = 0;
            foreach (Match m in numMatches)
            {dmg += double.Parse(m.Value);}
            foreach (Match match in oprMatches) {
                if (match.Value == "*")
                {dmg *= 2;}
                else if (match.Value == "/")
                {dmg /= 2;}}
            return dmg;
        }
    }
}
