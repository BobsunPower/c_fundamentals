using System;
using System.Linq;

namespace x08.MagicSum.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            int maxSize = 0; int max = 0;
            for (int i = 0; i < nums.Length; i++) {int size = 1; int n = nums[i];
                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] == nums[j]) {size++;}
                    else {break;}}
                if (size > maxSize) {maxSize = size; max = n;}}
            for (int i = 0; i < maxSize; i++) {Console.Write($"{max} ");}
        }
    }
}
