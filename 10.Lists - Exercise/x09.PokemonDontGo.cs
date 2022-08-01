using System;
using System.Collections.Generic;
using System.Linq;

namespace x09.PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList(); int sum = 0;
            while (nums.Count != 0) {int idx = int.Parse(Console.ReadLine());
                if (idx < 0) {idx = 0; int numIdx = nums[idx]; numIdx = nums[idx]; sum += numIdx;
                    CatchPokemon(nums, idx, numIdx); int numCopy = nums[nums.Count - 1]; nums.Insert(idx, numCopy);}
                else if (idx >= nums.Count) {idx = nums.Count - 1; int numIdx = nums[idx]; numIdx = nums[idx]; sum += numIdx;
                    CatchPokemon(nums, idx, numIdx); int numCopy = nums[0]; nums.Insert(idx, numCopy);}
                else {int numIdx = nums[idx]; sum += numIdx; CatchPokemon(nums, idx, numIdx);}}
            Console.WriteLine(sum);
        }
        static void CatchPokemon(List<int> nums, int idx, int numIdx)
        {

            for (int i = 0; i < nums.Count; i++) {
                if (nums[i] <= numIdx) {nums[i] += numIdx;}
                else {nums[i] -= numIdx;}}
            nums.RemoveAt(idx);
        }
    }
}
