using System;

namespace x08.DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 100; i++)
            {if (i % 3 == 0) { Console.WriteLine(i);}}
        }
    }
}
