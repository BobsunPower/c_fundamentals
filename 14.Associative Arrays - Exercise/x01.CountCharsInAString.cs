using System;
using System.Collections.Generic;

namespace x01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string txt = string.Join(string.Empty, Console.ReadLine().Split());
            Dictionary<char, int> chars = new Dictionary<char, int>();
            foreach (char ch in txt)
            {if (chars.ContainsKey(ch)) {chars[ch]++;}
                else {chars.Add(ch, 1);}}
            foreach (var ch in chars)
            {Console.WriteLine($"{ch.Key} -> {ch.Value}");}
        }
    }
}
