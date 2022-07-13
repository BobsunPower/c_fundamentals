using System;

namespace x01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine());
            int trd = int.Parse(Console.ReadLine()); int fth = int.Parse(Console.ReadLine());
            Console.WriteLine((fst + snd) / trd * fth);
        }
    }
}
