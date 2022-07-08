using System;

namespace x05.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()); int end = int.Parse(Console.ReadLine()) + 1; string nms = ""; int sum = 0;
            for (int i = start; i < end; i++) {nms += $"{i} ";  sum += i;}
            Console.WriteLine($@"{nms}
Sum: {sum}");
        }
    }
}
