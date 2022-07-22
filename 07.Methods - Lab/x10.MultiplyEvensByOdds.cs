using System;

namespace x10.MultiplyEvensByOdds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {int dgt = n % 10;
                if (dgt % 2 == 0) { sum += dgt;}
                n /= 10;}
            return sum;
        }

        static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n != 0)
            {int dgt = n % 10;
                if (dgt % 2 != 0) { sum += dgt;}
                n /= 10;}
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine())); int sumEven = GetSumOfEvenDigits(num); int sumOdd = GetSumOfOddDigits(num);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumEven, sumOdd));
        }        
    }
}
