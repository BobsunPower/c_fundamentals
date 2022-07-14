using System;

namespace x07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); int tot = 0;
            for (int i = 1; i <= n; i++) {int lit = int.Parse(Console.ReadLine());
                if (tot + lit > 255) {Console.WriteLine("Insufficient capacity!");}
                else {tot += lit;}}
            Console.WriteLine(tot);
        }
    }
}
