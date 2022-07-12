using System;

namespace x06.ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[3];
            for (int i = 0; i < c.Length; i++) {c[i] = char.Parse(Console.ReadLine());}
            for (int i = c.Length - 1; i > -1; i--) {Console.Write($"{c[i]} ");}
        }
    }
}
