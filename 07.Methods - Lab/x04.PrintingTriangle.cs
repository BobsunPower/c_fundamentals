using System;

namespace x04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void PrintLine(int start, int end)
            {for (int i = start; i <= end; i++) {Console.Write($"{i} ");}
                Console.WriteLine();}
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++) {PrintLine(1, i);}
            for (int i = n - 1; i >= 1; i--) {PrintLine(1, i);}}        
    }
}