using System;

namespace x10.PokeMon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int m = int.Parse(Console.ReadLine()); int y = int.Parse(Console.ReadLine());
            double p = (double)n * 0.5; int h = 0;
            while (n >= m) {n -= m; h++;
                if (p == n && y != 0) {n /= y;}}
            Console.WriteLine($"{n}\n{h}");
        }
    }
}
