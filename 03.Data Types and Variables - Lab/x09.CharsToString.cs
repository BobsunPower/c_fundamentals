using System;

namespace x09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[3];
            for (int i = 0; i < c.Length; i++) {c[i] = char.Parse(Console.ReadLine());}
            Console.Write(string.Join("", c));
        }
    }
}
