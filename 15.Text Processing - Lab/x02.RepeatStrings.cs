using System;
using System.Text;

namespace x02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            StringBuilder rep = new StringBuilder();
            foreach (string chs in str)
            {for (int i = 0; i < chs.Length; i++)
                {rep.Append(chs);}}
            Console.WriteLine(rep);
        }
    }
}
