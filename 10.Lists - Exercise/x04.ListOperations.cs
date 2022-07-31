using System;
using System.Collections.Generic;
using System.Linq;

namespace x04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string cmd = Console.ReadLine();
            while (cmd != "End") {string[] tkn = cmd.Split();
                if (tkn[0] == "Add") {int add = int.Parse(tkn[1]); nums.Add(add);}
                else if (tkn[0] == "Insert") {int ins = int.Parse(tkn[1]); int idx = int.Parse(tkn[2]);
                    if (idx < 0 || idx >= nums.Count) {Console.WriteLine("Invalid index");}
                    else {nums.Insert(idx, ins);}}
                else if (tkn[0] == "Remove") {int rem = int.Parse(tkn[1]);
                    if (rem < 0 || rem >= nums.Count) {Console.WriteLine("Invalid index");}
                    else {nums.RemoveAt(rem);}}
                else if (tkn[0] == "Shift" && tkn[1] == "left") {int rep = int.Parse(tkn[2]);
                    for (int i = 0; i < rep; i++) {int n = nums[0]; nums.RemoveAt(0); nums.Add(n);}}
                else if (tkn[0] == "Shift" && tkn[1] == "right") {int rep = int.Parse(tkn[2]);
                    for (int i = 0; i < rep; i++) {int n = nums[nums.Count - 1]; nums.Insert(0, n); nums.RemoveAt(nums.Count - 1);}}
                cmd = Console.ReadLine();}
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
