using System;
using System.Linq;

namespace x09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine()); int[] bestDNA = new int[l];
            int sumDNA = 0; int cntDNA = -1; int idxDNA = -1; int splDNA = 0; int spl = 0; string str;
            while ((str = Console.ReadLine()) != "Clone them!") {spl++;
                int[] curDNA = str.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int lDNA = 0; int sDNA = 0; int idxS = 0; int idxE = 0; bool btrDNA = false; int len = 0;
                for (int i = 0; i < curDNA.Length; i++) {
                    if (curDNA[i] != 1) {len = 0; continue;}
                    len++;
                    if (len > lDNA) {lDNA = len; idxE = i;}}
                idxS = idxE - lDNA + 1; sDNA = curDNA.Sum();
                if (lDNA > cntDNA) {btrDNA = true;}
                else if (lDNA == cntDNA)
                {if (idxS < idxDNA) {btrDNA = true;}
                    else if (idxS == idxDNA)
                    {if (sDNA > sumDNA) {btrDNA = true;}}}
                if (btrDNA) {bestDNA = curDNA; cntDNA = lDNA; idxDNA = idxS; sumDNA = sDNA; splDNA = spl;}}
            Console.WriteLine($"Best DNA sample {splDNA} with sum: {sumDNA}.");
            Console.WriteLine(String.Join(' ', bestDNA));
        }
    }
}
