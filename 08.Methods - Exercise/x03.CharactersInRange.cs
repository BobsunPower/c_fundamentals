using System;

namespace x03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine()); char b = char.Parse(Console.ReadLine()); CharactersInRange(a, b);
        }
        static void CharactersInRange(char a, char b)
        {
            int fst = Math.Min(a, b); int snd = Math.Max(a, b);
            for (int i = ++fst; i < snd; i++) {Console.Write((char)i + " ");}
        }
    }
}
