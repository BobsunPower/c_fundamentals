using System;
using System.Collections.Generic;

namespace x01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(", ");
            List<string> vldUsr = new List<string>();
            foreach (string wrd in str) {bool vld = true;
                if (wrd.Length >= 3 && wrd.Length <= 16){
                    foreach (char ch in wrd) {
                        if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '_')
                        {vld = false; break;}}
                    if (vld)
                    {vldUsr.Add(wrd);}}}
            foreach (string usr in vldUsr)
            {Console.WriteLine(usr);}
        }
    }
}
