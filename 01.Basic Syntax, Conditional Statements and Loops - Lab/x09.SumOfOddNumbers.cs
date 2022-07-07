using System;

namespace x09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nms = int.Parse(Console.ReadLine());
            int odd = 1; int ctr = 0; int sum = 0;
            while (ctr < nms) {Console.WriteLine(odd); ctr++; sum += odd; odd += 2;}
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
