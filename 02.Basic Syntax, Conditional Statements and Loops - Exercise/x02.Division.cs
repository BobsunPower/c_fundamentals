using System;

namespace x02.Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int d = 0;
            if (n % 10 == 0) {d = 10;}
            else if (n % 7 == 0) {d = 7;}
            else if (n % 6 == 0) {d = 6;}
            else if (n % 3 == 0) {d = 3;}
            else if (n % 2 == 0) {d = 2;}
            else {Console.WriteLine("Not divisible");}
            if (d > 0) {Console.WriteLine($"The number is divisible by {d}");}
        }
    }
}
