using System;
using System.Collections.Generic;
using System.Linq;

namespace x01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach (int n in numbers)
            {if (counts.ContainsKey(n)) {counts[n]++;}
                else {counts.Add(n, 1);}}
            foreach (var n in counts)
            {Console.WriteLine($"{n.Key} -> {n.Value}");}
        }
    }
}
