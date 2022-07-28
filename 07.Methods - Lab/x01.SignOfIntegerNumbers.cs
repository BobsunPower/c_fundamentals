using System;

namespace x01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingOfNumber();
        }
        static void SingOfNumber()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0) {Console.WriteLine($"The number {n} is zero. ");}
            else if (n > 0) {Console.WriteLine($"The number {n} is positive.");}
            else {Console.WriteLine($"The number {n} is negative.");}
        }
    }
}
