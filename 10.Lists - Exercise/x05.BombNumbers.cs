using System;
using System.Collections.Generic;
using System.Linq;

namespace x05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList(); string[] bmb = Console.ReadLine().Split();
            int num = int.Parse(bmb[0]); int pwr = int.Parse(bmb[1]);
            for (int i = 0; i < nums.Count; i++) {
                if (nums[i] == num) {int start = i - pwr; int end = i + pwr;
                    if (start < 0) start = 0;
                    if (end > nums.Count) end = nums.Count - 1;
                    for (int j = start; j <= end; j++) {nums[j] = 0;}}}
            Console.WriteLine(nums.Sum());
        }
    }
}
