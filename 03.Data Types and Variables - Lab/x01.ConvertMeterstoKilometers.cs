using System;

namespace x01.ConvertMeterstoKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine()); Console.WriteLine($"{m / 1000.0:f2}");
        }
    }
}
