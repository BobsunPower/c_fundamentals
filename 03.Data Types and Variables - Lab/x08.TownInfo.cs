using System;

namespace x08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string t = Console.ReadLine(); int p = int.Parse(Console.ReadLine()); int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Town {t} has population of {p} and area {a} square km.");
        }
    }
}
