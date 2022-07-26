using System;
using System.Collections.Generic;
using System.Linq;

namespace x02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newNums = new List<int>();
            for (int i = 0; i < nums.Count / 2; i++) {int n = nums[i] + nums[nums.Count - 1 - i]; newNums.Add(n);}
            if (nums.Count % 2 != 0) {newNums.Add(nums[nums.Count / 2]);}
            Console.WriteLine(string.Join(' ', newNums));
        }
    }
}
