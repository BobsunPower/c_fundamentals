using System;
using System.Collections.Generic;

namespace x02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rsrs = new Dictionary<string, int>();
            while (true) {string r = Console.ReadLine();
                if (r == "stop") {break;}
                int qty = int.Parse(Console.ReadLine());
                if (rsrs.ContainsKey(r)) {rsrs[r] += qty;}
                else {rsrs.Add(r, qty);}}
            foreach (var r in rsrs) {Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
