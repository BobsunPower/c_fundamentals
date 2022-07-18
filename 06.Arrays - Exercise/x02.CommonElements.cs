using System;

namespace x02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fst = Console.ReadLine().Split(); string[] snd = Console.ReadLine().Split();
            for (int i = 0; i < fst.Length; i++)
            {for (int j = 0; j < snd.Length; j++)
                {if (fst[i] == snd[j]) {Console.Write($"{fst[i]} ");}}
            }
        }
    }
}
