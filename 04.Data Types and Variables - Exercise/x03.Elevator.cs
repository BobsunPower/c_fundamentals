using System;

namespace x03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine()); int cap = int.Parse(Console.ReadLine());
            double css = Math.Ceiling((double)ppl / cap);
            Console.WriteLine(css);
        }
    }
}
