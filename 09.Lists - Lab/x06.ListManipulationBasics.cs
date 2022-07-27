using System;
using System.Collections.Generic;
using System.Linq;

namespace x06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string cmd = Console.ReadLine();
            while (cmd != "end") {
                string[] tkn = cmd.Split(' ');
                string act = tkn[0];
                if (act == "Add") {int addNum = int.Parse(tkn[1]); nums.Add(addNum);}
                else if (act == "Remove") {int remNum = int.Parse(tkn[1]); nums.Remove(remNum);}
                else if (act == "RemoveAt") {int remIdx = int.Parse(tkn[1]); nums.RemoveAt(remIdx);}
                else if (act == "Insert") {int addNum = int.Parse(tkn[1]); int addIdx = int.Parse(tkn[2]); nums.Insert(addIdx, addNum);}
                cmd = Console.ReadLine();}
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
