using System;

namespace x11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); string sign = Console.ReadLine(); int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, sign, b));
        }
        static double Calculate(int x, string s, int y)
        {
            double result = 0;
            switch (s) {
                case "+": result = x + y; break;
                case "-": result = x - y; break;
                case "*": result = x * y; break;
                case "/": result = x / y; break;}
            return result;
        }        
    }
}
