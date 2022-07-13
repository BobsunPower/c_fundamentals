using System;

namespace x10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c = char.Parse(Console.ReadLine());
            if (char.IsLower(c)) {Console.WriteLine("lower-case");}
            else if (char.IsUpper(c)) {Console.WriteLine("upper-case");}
        }
    }
}
