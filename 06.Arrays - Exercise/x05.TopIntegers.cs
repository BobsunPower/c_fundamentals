using System;
using System.Linq;

namespace x05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            for (int i = 0; i < nums.Length; i++) {bool top = true;
                for (int j = i + 1; j < nums.Length; j++)
                {if (nums[i] <= nums[j]) { top = false; break;}}
                if (top) {Console.Write(nums[i] + " ");}
            }
        }
    }
}
