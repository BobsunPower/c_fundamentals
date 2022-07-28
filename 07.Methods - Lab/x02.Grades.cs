using System;

namespace x02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintInWords(grade);
        }
        static void PrintInWords(double g)
        {
            string r = "";
            if (g < 3) {r = "Fail";}
            else if (g < 3.5) {r = "Poor";}
            else if (g < 4.5) {r = "Good";}
            else if (g < 5.5) {r = "Very good";}
            else {r = "Excellent";}
            Console.WriteLine(r);
        }
    }
}
