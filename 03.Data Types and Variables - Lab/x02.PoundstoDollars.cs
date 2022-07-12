using System;

namespace x02.PoundstoDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal p = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{p * 1.31m:f3}");
        }
    }
}
