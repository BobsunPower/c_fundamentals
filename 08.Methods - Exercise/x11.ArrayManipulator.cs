using System;
using System.Collections.Generic;
using System.Linq;

namespace x11.ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray(); string[] cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "end") {
                if (cmd[0] == "exchange") {arr = ExchangedArray(arr, int.Parse(cmd[1]));}
                else if (cmd[0] == "min" || cmd[0] == "max") {FindMinMax(arr, cmd[0], cmd[1]);}
                else if (cmd[0] == "first" || cmd[0] == "last") {FindNumbers(arr, cmd[0], int.Parse(cmd[1]), cmd[2]);}
                cmd = Console.ReadLine().Split().ToArray();}
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }
        static int[] ExchangedArray(int[] cntArr, int xchIdx)
        {
            if (xchIdx < 0 || xchIdx >= cntArr.Length) {Console.WriteLine("Invalid index"); return cntArr;}
            int[] newArr = new int[cntArr.Length]; int strIdx = 0;
            for (int i = xchIdx + 1; i < cntArr.Length; i++) {newArr[strIdx] = cntArr[i]; strIdx++;}
            for (int i = 0; i <= xchIdx; i++) {newArr[strIdx] = cntArr[i]; strIdx++;}
            return newArr;
        }
        static void FindMinMax(int[] cntArr, string minMax, string evenOdd)
        {
            int idx = -1; int min = int.MaxValue; int max = int.MinValue; int res = 1;
            if (evenOdd == "even") res = 0;
            for (int i = 0; i < cntArr.Length; i++) {
                if (cntArr[i] % 2 == res) {
                    if (minMax == "min" && min >= cntArr[i]) {min = cntArr[i]; idx = i;}
                    else if (minMax == "max" && max <= cntArr[i]) {max = cntArr[i]; idx = i;}}}
            if (idx > -1) Console.WriteLine(idx);
            else Console.WriteLine("No matches");
        }
        static void FindNumbers(int[] cntArr, string pos, int n, string evenOrOdd)
        {
            if (n > cntArr.Length) {Console.WriteLine("Invalid count"); return;}
            if (n == 0) {Console.WriteLine("[]"); return;}
            int res = 1;
            if (evenOrOdd == "even") res = 0;
            int cnt = 0;
            List<int> nums = new List<int>();
            if (pos == "first") {
                foreach (var num in cntArr) {
                    if (num % 2 == res) {cnt++; nums.Add(num);}
                    if (cnt == n) break;}}
            else {
                for (int i = cntArr.Length - 1; i >= 0; i--) {
                    if (cntArr[i] % 2 == res) {cnt++; nums.Add(cntArr[i]);}
                    if (cnt == n) break;}
                nums.Reverse();}
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
