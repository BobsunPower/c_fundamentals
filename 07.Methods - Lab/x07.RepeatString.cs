using System;
using System.Text;

namespace x07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); int r = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(s, r));
        }
        private static string RepeatString(string str, int rep)
        {
            StringBuilder txt = new StringBuilder();
            for (int i = 0; i < rep; i++) { txt.Append(str); }
            return txt.ToString();
        }
    }
}
