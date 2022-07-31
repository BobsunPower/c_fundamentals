using System;
using System.Collections.Generic;
using System.Linq;

namespace x07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToArray();
            int[] nums = new int[arr.Length]; List<int> res = new List<int>();
            for (int i = arr.Length - 1; i >= 0; i--) {
                nums = arr[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                foreach (var n in nums) {res.Add(n);}}
            Console.WriteLine(string.Join(' ', res));
        }
    }
}
