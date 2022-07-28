using System;
using System.Collections.Generic;
using System.Linq;

namespace x02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList(); string cmd = Console.ReadLine();
            while (cmd != "end") {string[] tkn = cmd.Split();
                if (tkn[0] == "Delete") {int delNum = int.Parse(tkn[1]); nums.RemoveAll(x => x == delNum);}
                else if (tkn[0] == "Insert") {int elm = int.Parse(tkn[1]); int pos = int.Parse(tkn[2]); nums.Insert(pos, elm);}
                cmd = Console.ReadLine();}
            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
