using System;

namespace x06.CalculateRectangleArea
{
    internal class Program
    {
        private static double GetRectangleArea(double w, double h)
        {return w * h;}
        static void Main(string[] args)
        {double width = double.Parse(Console.ReadLine()); double height = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(width, height));}        
    }
}
