using System;

namespace x01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine()); int z = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestNumber(x, y, z));
        }        
    }
}
