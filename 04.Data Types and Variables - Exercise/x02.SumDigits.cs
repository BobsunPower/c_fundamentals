using System;
using System.Linq;

namespace x02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nms = n.ToString() .Select(x => int.Parse(x.ToString())) .ToArray();
            int sum = 0;
            for (int i = 0; i < nms.Length; i++) {sum += nms[i];}
            Console.WriteLine(sum);
        }
    }
}
