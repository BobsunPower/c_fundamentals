using System;

namespace x07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int rem = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == '>')
                {rem += str[i + 1] - '0';}
                else if (rem > 0)
                {str = str.Remove(i, 1); rem--; i--;}}
            Console.WriteLine(str);
        }
    }
}
