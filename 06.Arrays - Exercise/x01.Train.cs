using System;

namespace x01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine()); int[] wagons = new int[l]; int sum = 0;
            for (int idx = 0; idx < wagons.Length; idx++)
            {wagons[idx] = int.Parse(Console.ReadLine()); sum += wagons[idx];}
            foreach (int w in wagons) {Console.Write(w + " ");}
            Console.WriteLine($"\n{sum}");
        }
    }
}
