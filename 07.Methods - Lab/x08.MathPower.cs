using System;

namespace x08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine()); int pwr = int.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(num, pwr));
        }
        static double RaiseToPower(double n, int p)
        {
            double res = 1;
            for (int i = 0; i < p; i++) { res *= n; }
            return res;
        }        
    }
}
