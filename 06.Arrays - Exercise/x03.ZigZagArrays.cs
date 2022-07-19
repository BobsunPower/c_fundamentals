using System;
using System.Linq;

namespace x03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int[] fst = new int[n]; int[] snd = new int[n];
            for (int i = 0; i < n; i++)
            {int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0) {snd[i] = line[0]; fst[i] = line[1];}
                else {snd[i] = line[1];fst[i] = line[0];}}
            Console.WriteLine(string.Join(' ', snd));
            Console.WriteLine(string.Join(' ', fst));
        }
    }
}
