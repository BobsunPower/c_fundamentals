using System;
using System.Linq;

namespace x04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] c = Console.ReadLine() .Split() .ToArray();
            for (int i = c.Length - 1; i >= 0; i--) {Console.Write($"{c[i]} ");}
        }
    }
}
