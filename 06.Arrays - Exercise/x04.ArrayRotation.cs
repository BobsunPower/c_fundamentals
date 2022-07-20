using System;
using System.Linq;

namespace x04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine() .Split() .Select(int.Parse) .ToArray();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {int fst = nums[0];
                for (int j = 1; j < nums.Length; j++) {nums[j - 1] = nums[j];}
                nums[nums.Length - 1] = fst;}
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
