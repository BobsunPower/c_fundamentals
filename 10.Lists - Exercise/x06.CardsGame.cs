using System;
using System.Collections.Generic;
using System.Linq;

namespace x06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> snd = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true) {int idx = 0;
                if (fst.Count == 0 || snd.Count == 0) {break;}
                else {
                    if (fst[idx] == snd[idx]) {fst.RemoveAt(idx); snd.RemoveAt(idx); continue;}
                    if (fst[idx] > snd[idx]) {int win = fst[idx]; int los = snd[idx];
                        fst.RemoveAt(idx); snd.RemoveAt(idx); fst.Add(los); fst.Add(win);}
                    else {int win = snd[idx]; int los = fst[idx];
                        fst.RemoveAt(idx); snd.RemoveAt(idx); snd.Add(los); snd.Add(win);}}}
            if (fst.Count == 0) {Console.WriteLine($"Second player wins! Sum: {snd.Sum()}");}
            else {Console.WriteLine($"First player wins! Sum: {fst.Sum()}");}
        }
    }
}
