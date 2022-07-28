using System;

namespace x10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine())); int sumEven = SumEvenDigits(num); int sumOdd = SumOddDigits(num);
            Console.WriteLine(MultiplyEvenOdds(sumEven, sumOdd));
        }
        static int SumEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0) {int dgt = n % 10;
                if (dgt % 2 == 0) {sum += dgt;}
                n /= 10;}
            return sum;
        }
        static int SumOddDigits(int n)
        {
            int sum = 0;
            while (n != 0) {int dgt = n % 10;
                if (dgt % 2 != 0) {sum += dgt;}
                n /= 10;}
            return sum;
        }
        static int MultiplyEvenOdds(int even, int odd)
        {
            return even * odd;
        }        
    }
}
