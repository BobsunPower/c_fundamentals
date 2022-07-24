using System;

namespace x06.MiddleCharacters
{
    internal class Program
    {
        static string MidCharacter(string str)
        {
            int idx = str.Length / 2; string res = "";
            if (str.Length % 2 == 0) {res = str[idx - 1].ToString() + str[idx].ToString();}
            else {res = str[idx].ToString();}
            return res;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(MidCharacter(str));
        }

        
    }
}
