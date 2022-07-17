using System;
using System.Linq;

namespace x07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fst = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            int[] snd = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            for (int i = 0; i < fst.Length; i++) {if (fst[i] != snd[i])
                {Console.WriteLine($"Arrays are not identical. Found difference at {i} index"); return;}}
            Console.WriteLine($"Arrays are identical. Sum: {fst.Sum()}");
        }
    }
}
