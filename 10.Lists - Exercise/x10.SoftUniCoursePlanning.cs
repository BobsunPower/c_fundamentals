using System;
using System.Linq;
using System.Collections.Generic;

namespace x10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lsn = Console.ReadLine().Split(", ").ToList();
            string[] data = Console.ReadLine().Split(':').ToArray();
            while (data[0] != "course start") {string cmd = data[0]; string ttlLsn = data[1];
                if (cmd == "Add") {
                    if (!lsn.Contains(ttlLsn)) {lsn.Add(ttlLsn);}}
                else if (cmd == "Insert") {int idx = int.Parse(data[2]);
                    if (!lsn.Contains(ttlLsn)) {
                        if (idx < lsn.Count && idx >= 0) {lsn.Insert(idx, ttlLsn);}}}
                else if (cmd == "Remove") {lsn.Remove(ttlLsn); lsn.Remove($"{ttlLsn}-Exercise");}
                else if (cmd == "Swap") {string swpLsn = data[2]; int fstIdx = lsn.IndexOf(ttlLsn); int sndIdx = lsn.IndexOf(swpLsn);
                    if (fstIdx != -1 && sndIdx != -1) {lsn[fstIdx] = swpLsn; lsn[sndIdx] = ttlLsn;
                        if (fstIdx + 1 < lsn.Count && lsn[fstIdx + 1] == $"{ttlLsn}-Exercise")
                        {lsn.RemoveAt(fstIdx + 1); fstIdx = lsn.IndexOf(ttlLsn); lsn.Insert(fstIdx + 1, $"{ttlLsn}-Exercise");}
                        if (sndIdx + 1 < lsn.Count && lsn[sndIdx + 1] == $"{swpLsn}-Exercise")
                        {lsn.RemoveAt(sndIdx + 1); sndIdx = lsn.IndexOf(swpLsn); lsn.Insert(sndIdx + 1, $"{swpLsn}-Exercise");}}}
                else if (cmd == "Exercise") {int idx = lsn.IndexOf(ttlLsn);
                    if (lsn.Contains(ttlLsn) && !lsn.Contains($"{ttlLsn}-Exercise")) {lsn.Insert(idx + 1, $"{ttlLsn}-Exercise");}
                    else if (!lsn.Contains(ttlLsn)) {lsn.Add(ttlLsn); lsn.Add($"{ttlLsn}-Exercise");}}
                data = Console.ReadLine().Split(':').ToArray();}
            for (int i = 0; i < lsn.Count; i++) {Console.WriteLine($"{i + 1}.{lsn[i]}");}
        }
    }
}
