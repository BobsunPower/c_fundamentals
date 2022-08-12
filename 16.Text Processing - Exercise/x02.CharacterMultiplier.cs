using System;

namespace x02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(); int sum = 0;
            string fst = data[0]; string snd = data[1];
            string lng; string sth;
            if (fst.Length > snd.Length)
            {lng = fst; sth = snd;}
            else
            {lng = snd; sth = fst;}
            int cnt = 0;
            for (int i = 0; i < sth.Length; i++)
            {sum += fst[i] * snd[i]; cnt++;}
            for (int i = cnt; i < lng.Length; i++)
            {sum += lng[i];}
            Console.WriteLine(sum);
        }
    }
}
