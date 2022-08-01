using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace x08.AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true) {string[] data = Console.ReadLine().Split().ToArray(); string cmd = data[0];
                if (cmd == "3:1") {break;}
                if (cmd == "merge") {int startIdx = int.Parse(data[1]); int endIdx = int.Parse(data[2]);
                    if (startIdx < 0 || startIdx >= lst.Count) startIdx = 0;
                    if (endIdx >= lst.Count) endIdx = lst.Count - 1;
                    StringBuilder mrg = new StringBuilder();
                    for (int i = startIdx; i <= endIdx; i++) {mrg.Append(lst[startIdx]); lst.RemoveAt(startIdx);}
                    lst.Insert(startIdx, mrg.ToString());}
                else if (cmd == "divide") {int divIdx = int.Parse(data[1]); int divPar = int.Parse(data[2]); string divWrd = lst[divIdx];
                    if (divPar > divWrd.Length) {return;}
                    List<string> par = new List<string>();
                    int lenPar = divWrd.Length / divPar;
                    for (int i = 0; i < divPar; i++) {char[] cntPar;
                        if (i == divPar - 1) {cntPar = divWrd .Skip(i * lenPar) .Take(lenPar + divWrd.Length % divPar) .ToArray();}
                        else {cntPar = divWrd .Skip(i * lenPar) .Take(lenPar) .ToArray();}
                        par.Add(new string(cntPar));}
                    lst.RemoveAt(divIdx);
                    lst.InsertRange(divIdx, par);}}
            Console.WriteLine(string.Join(' ', lst));
        }
    }
}
