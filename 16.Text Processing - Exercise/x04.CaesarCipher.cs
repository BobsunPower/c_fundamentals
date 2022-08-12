using System;
using System.Text;

namespace x04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            StringBuilder res = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {char ch = data[i]; ch += (char)3; res.Append(ch);}
            Console.WriteLine(res);
        }
    }
}
