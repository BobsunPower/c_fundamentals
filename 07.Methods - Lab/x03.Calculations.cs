using System;

namespace x03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {            
        static void Add(int a, int b)
        {Console.WriteLine(a + b);}

        static void Multiply(int a, int b)
        {Console.WriteLine(a * b);}

        static void Subtract(int a, int b)
        {Console.WriteLine(a - b);}

        static void Divide(int a, int b)
        {Console.WriteLine(a / b);}
            string cmd = Console.ReadLine(); int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine());
            switch (cmd) {
                case "add": Add(fst, snd); break;
                case "multiply": Multiply(fst, snd); break;
                case "subtract": Subtract(fst, snd); break;
                case "divide": Divide(fst, snd); break;}
        }
    }
}
