using System;

namespace x05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fst = int.Parse(Console.ReadLine()); int snd = int.Parse(Console.ReadLine()); int trd = int.Parse(Console.ReadLine());
            int res = Subtract(Sum(fst, snd), trd);
            Console.WriteLine(res);
        }
        static int Sum(int fst, int snd)
        {
            return fst + snd;
        }
        static int Subtract(int fst, int snd)
        {
            return fst - snd;
        }        
    }
}
