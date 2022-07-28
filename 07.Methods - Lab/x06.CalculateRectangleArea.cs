using System;

namespace x06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()); double height = double.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(width, height));
        }
        private static double RectangleArea(double w, double h)
        {
            return w * h;
        }        
    }
}
