using System;

namespace x09.GreaterOfTwoValues
{
    internal class Program
    {
        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        static char GetMax(char a, char b)
        {
            return (char)Math.Max(a, b);
        }

        static string GetMax(string a, string b)
        {
            int comparison = a.CompareTo(b);
            if (comparison > 0) { return a; }
            else { return b; }
        }
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            switch (data) {
                case "int": int fstNum = int.Parse(Console.ReadLine()); int sndNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(fstNum, sndNum)); break;
                case "char": char fstChr = char.Parse(Console.ReadLine()); char sndChr = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(fstChr, sndChr)); break;
                case "string":
                    string fstStr = Console.ReadLine(); string sndStr = Console.ReadLine();
                    Console.WriteLine(GetMax(fstStr, sndStr)); break;
            }

        }

        

    }
}
