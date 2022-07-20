using System;
using System.Linq;

namespace x06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            for (int i = 0; i < nums.Length; i++) {int l = 0; int r = 0;
                for (int j = 0; j < i; j++) {l += nums[j];}
                for (int k = i + 1; k < nums.Length; k++) {r += nums[k];}
                if (l == r) {Console.WriteLine(i); return;}}
            Console.WriteLine("no");
        }
    }
}
