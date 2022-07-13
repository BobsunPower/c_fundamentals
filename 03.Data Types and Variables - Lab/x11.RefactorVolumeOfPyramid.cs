using System;

namespace x11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine()); double w = double.Parse(Console.ReadLine()); double h = double.Parse(Console.ReadLine());
            Console.WriteLine($@"Length: Width: Height: Pyramid Volume: {1 / 3.0 * (l * w) * h:f2}");
        }
    }
}
