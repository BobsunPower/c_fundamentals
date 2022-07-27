using System;
using System.Collections.Generic;
using System.Linq;

namespace x07.ListManipulationAdvanced
{
    internal class Program
    {
        static List<int> FilterNumbers(List<int> nums, string cnd, int n)
        {
            if (cnd == "<") {List<int> res = nums.FindAll(x => x < n); return res;}
            else if (cnd == ">") {List<int> res = nums.FindAll(x => x > n); return res;}
            else if (cnd == "<=") {List<int> res = nums.FindAll(x => x <= n); return res;}
            else if (cnd == ">=") {List<int> res = nums.FindAll(x => x >= n); return res;}
            else {return nums;}
        }
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList(); string cmd = Console.ReadLine(); bool chg = false;
            while (cmd != "end") {
                string[] tkn = cmd.Split(' '); string act = tkn[0];
                if (act == "Add") {int addNum = int.Parse(tkn[1]); nums.Add(addNum); chg = true;}
                else if (act == "Remove") {int remNum = int.Parse(tkn[1]); nums.Remove(remNum); chg = true;}
                else if (act == "RemoveAt") {int remIdx = int.Parse(tkn[1]); nums.RemoveAt(remIdx); chg = true;}
                else if (act == "Insert") {int addNum = int.Parse(tkn[1]); int addIdx = int.Parse(tkn[2]); nums.Insert(addIdx, addNum); chg = true;}
                else if (act == "Contains") {int conNum = int.Parse(tkn[1]);
                    if (nums.Contains(conNum)) {Console.WriteLine("Yes");}
                    else {Console.WriteLine("No such number");}}
                else if (act == "PrintEven") {List<int> even = nums.FindAll(x => x % 2 == 0); Console.WriteLine(string.Join(' ', even));}
                else if (act == "PrintOdd") {List<int> odd = nums.FindAll(x => x % 2 != 0);Console.WriteLine(string.Join(' ', odd));}
                else if (act == "GetSum") {Console.WriteLine(nums.Sum());}
                else if (act == "Filter") {string cnd = tkn[1]; int n = int.Parse(tkn[2]); List<int> res = FilterNumbers(nums, cnd, n); Console.WriteLine(string.Join(' ', res));}
                cmd = Console.ReadLine();}
            if (chg) Console.WriteLine(string.Join(' ', nums));
        }        
    }
}
