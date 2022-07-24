using System;

namespace x08.FactorialDivision
{
    internal class Program
    {
        static double Factorial(int n)
        {
            double res = 1;
            for (int i = 1; i <= n; i++) {res *= i;}
            return res;
        }
        static void Main(string[] args)
        {
            int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Factorial(fst) / Factorial(snd):f2}");
        }
    }
}
