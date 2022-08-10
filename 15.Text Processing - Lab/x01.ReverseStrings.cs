using System;

namespace x01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            while (str != "end")
            {char[] rev = str.ToCharArray(); Array.Reverse(rev); string res = new string(rev);
                Console.WriteLine($"{str} = {res}");
                str = Console.ReadLine();
            }
        }
    }
}
