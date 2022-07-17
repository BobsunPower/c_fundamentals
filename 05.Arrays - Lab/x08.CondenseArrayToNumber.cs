using System;
using System.Linq;

namespace x08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            int[] con = new int[num.Length];
            while (num.Length > 1) {Array.Resize(ref con, con.Length - 1);
                for (int i = 0; i < num.Length - 1; i++)
                {if (num.Length > 1) {con[i] = num[i] + num[i + 1];}}
                Array.Resize(ref num, num.Length - 1);
                num = con;}
            Console.WriteLine(num[0]);
        }
    }
}
