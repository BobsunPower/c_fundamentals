using System;

namespace x03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rem = Console.ReadLine(); string str = Console.ReadLine();
            while (str.Contains(rem))
            {int idx = str.IndexOf(rem); str = str.Remove(idx, rem.Length);}
            Console.WriteLine(str);
        }
    }
}
