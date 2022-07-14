using System;

namespace x08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); double bgr = 0; string keg = "";
            for (int i = 1; i <= n; i++) {
                string k = Console.ReadLine(); double r = double.Parse(Console.ReadLine()); int h = int.Parse(Console.ReadLine());
                double v = Math.PI * r * r * h;
                if (bgr < v) {bgr = v; keg = k;}}
            Console.WriteLine(keg);
        }
    }
}
