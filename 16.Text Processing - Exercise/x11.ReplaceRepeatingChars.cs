using System;

namespace x11.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string res = "";
            for (int i = 0; i < str.Length; i++) {
                if (i == str.Length - 1)
                {res += str[i];}
                else if (str[i] != str[i + 1])
                {res += str[i];}}
            Console.WriteLine(res);
        }
    }
}
