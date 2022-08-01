using System;
using System.Numerics;

namespace x02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); BigInteger fac = 1;
            for (int i = 2; i <= n; i++) {fac *= i;} Console.WriteLine(fac);
        }
    }
}
