using System;

namespace x10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {if (Divisability(i) && OddDigit(i)) {Console.WriteLine(i);}}
        }
        static bool Divisability(int number)
        {
            int sum = 0;
            while (number != 0) {int dgt = number % 10; sum += dgt; number /= 10;}
            if (sum % 8 == 0) {return true;}
            return false;
        }
        static bool OddDigit(int n)
        {
            while (n != 0) {int dgt = n % 10;
                if (dgt % 2 == 1) {return true;}
                n /= 10;}
            return false;
        }        
    }
}
