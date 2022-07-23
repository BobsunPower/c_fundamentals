using System;
using System.Linq;

namespace x02.VowelsCount
{
    internal class Program
    {
        static int VowelCounter(string str)
        {
            string txt = str.ToLower(); int cnt = 0; char[] vow = new char[] { 'a', 'o', 'e', 'u', 'i' };
            foreach (char ch in txt) { if (vow.Contains(ch)) { cnt++; }} return cnt;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine(); Console.WriteLine(VowelCounter(str));
        }        
    }
}
