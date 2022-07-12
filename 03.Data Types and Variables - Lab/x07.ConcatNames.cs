using System;

namespace x07.ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fst = Console.ReadLine(); string snd = Console.ReadLine(); string sgn = Console.ReadLine();
            Console.WriteLine($"{fst}{sgn}{snd}");
        }
    }
}
