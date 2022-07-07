using System;

namespace x04.PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine()) + 30;
            if (m > 59) {m -= 60; h++;}
            if (h > 23) {h = 0;}
            Console.WriteLine($"{h}:{m:d2}");
        }
    }
}
