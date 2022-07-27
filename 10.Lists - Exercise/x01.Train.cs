using System;
using System.Collections.Generic;
using System.Linq;

namespace x01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ppl = Console.ReadLine().Split().Select(int.Parse).ToList(); int cap = int.Parse(Console.ReadLine()); string cmd = Console.ReadLine();
            while (cmd != "end") {
                string[] tkn = cmd.Split();
                if (tkn[0] == "Add") {int addWgn = int.Parse(tkn[1]); ppl.Add(addWgn);}
                else {int cnt = int.Parse(tkn[0]);
                    for (int i = 0; i < ppl.Count; i++) {
                        if (ppl[i] + cnt <= cap) {ppl[i] += cnt; break;}}}
                cmd = Console.ReadLine();}
            Console.WriteLine(string.Join(' ', ppl));
        }
    }
}
