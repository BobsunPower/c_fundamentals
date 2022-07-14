using System;
using System.Numerics;

namespace x11.Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); BigInteger ball = 0; string best = "";
            for (int i = 1; i <= n; i++) {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int qty = int.Parse(Console.ReadLine());
                BigInteger vlu = BigInteger.Pow(snow / time, qty);
                if (ball < vlu) {ball = vlu; best = $"{snow} : {time} = {vlu} ({qty})";}}
            Console.WriteLine(best);
        }
    }
}
