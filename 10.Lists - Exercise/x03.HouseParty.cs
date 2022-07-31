using System;
using System.Collections.Generic;

namespace x03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> ppl = new List<string>();
            for (int i = 0; i < n; i++) {
                string[] tkn = Console.ReadLine().Split(' '); string name = tkn[0];
                if (tkn.Length == 3) {
                    if (ppl.Contains(name)) {Console.WriteLine($"{name} is already in the list!");}
                    else {ppl.Add(name);}}
                else {
                    if (ppl.Contains(name)) {ppl.Remove(name);}
                    else {Console.WriteLine($"{name} is not in the list!");}}}
            foreach (var name in ppl) {Console.WriteLine(name);}
        }
    }
}
