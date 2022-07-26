using System;
using System.Collections.Generic;
using System.Linq;

namespace x03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> fst = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> snd = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> res = new List<int>();
            int longer = Math.Max(fst.Count, snd.Count);
            for (int i = 0; i < longer; i++) {
                if (i < fst.Count) {res.Add(fst[i]);}
                if (i < snd.Count) {res.Add(snd[i]);}}
            Console.WriteLine(string.Join(' ', res));
        }
    }
}
