using System;

namespace x01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wds = Console.ReadLine().Split(); Random rnd = new Random();
            for (int fstIdx = 0; fstIdx < wds.Length; fstIdx++)
            {int sndIdx = rnd.Next(wds.Length); string tmp = wds[fstIdx]; wds[fstIdx] = wds[sndIdx]; wds[sndIdx] = tmp;}
            Console.WriteLine(string.Join(Environment.NewLine, wds));
        }
    }
}
