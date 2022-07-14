using System;

namespace x04.SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int sum = 0;
            for (int i = 1; i <= n; i++)
            {char c = char.Parse(Console.ReadLine()); sum += c;}
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
