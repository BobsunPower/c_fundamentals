using System;
using System.Linq;

namespace x07.Strongnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = n.ToString() .Select(x => int.Parse(x.ToString())) .ToArray();
            int sum = 0;
            for (int i = 0; i < num.Length; i++) {int fac = 1;
                for (int j = 1; j <= num[i]; j++) {fac *= j;}
                sum += fac;}
            if (sum == n) {Console.WriteLine("yes");}
            else {Console.WriteLine("no");}
        }
    }
}
