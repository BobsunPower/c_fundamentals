using System;

namespace x09.PalindromeIntegers
{
    internal class Program
    {
        static bool PalindromeInteger(string n)
        {
            for (int i = 0; i < n.Length / 2; i++)
            {if (n[i] != n[n.Length - i - 1]) {return false;}}
            return true;
        }
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            while (cmd != "END") {Console.WriteLine(PalindromeInteger(cmd) .ToString(). ToLower()); cmd = Console.ReadLine();}
        }        
    }
}
