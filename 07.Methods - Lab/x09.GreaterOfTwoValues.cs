using System;

namespace x09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            switch (data) {
                case "int": int fstNum = int.Parse(Console.ReadLine()); int sndNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(Max(fstNum, sndNum)); break;
                case "char": char fstChr = char.Parse(Console.ReadLine()); char sndChr = char.Parse(Console.ReadLine());
                    Console.WriteLine(Max(fstChr, sndChr)); break;
                case "string": string fstStr = Console.ReadLine(); string sndStr = Console.ReadLine();
                    Console.WriteLine(Max(fstStr, sndStr)); break;}
        }
        static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }
        static char Max(char a, char b)
        {
            return (char)Math.Max(a, b);
        }
        static string Max(string a, string b)
        {
            int cmp = a.CompareTo(b);
            if (cmp > 0) {return a;}
            else {return b;}
        }        
    }
}
