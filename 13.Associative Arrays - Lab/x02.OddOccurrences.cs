using System;
using System.Collections.Generic;
using System.Linq;

namespace x02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            foreach (string word in words) {string lowWord = word.ToLower();
                if (counts.ContainsKey(lowWord)) {counts[lowWord]++;}
                else {counts.Add(lowWord, 1);}}
            string[] str = counts .Where(item => item.Value % 2 != 0) .Select(item => item.Key) .ToArray();
            Console.WriteLine(string.Join(' ', str));
        }
    }
}
