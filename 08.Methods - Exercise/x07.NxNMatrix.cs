using System;

namespace x07.NxNMatrix
{
    internal class Program
    {
        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {for (int j = 0; j < n; j++) {Console.Write(n + " ");}
                Console.WriteLine();}
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }
    }
}
