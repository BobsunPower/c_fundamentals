using System;
using System.Collections.Generic;
using System.Linq;

namespace x06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {string name = Console.ReadLine(); double grd = double.Parse(Console.ReadLine());
                if (!grades.ContainsKey(name))
                {grades.Add(name, new List<double>());}
                grades[name].Add(grd);}
            foreach (var std in grades.Where(std => std.Value.Average() >= 4.50))
            {Console.WriteLine($"{std.Key} -> {std.Value.Average():f2}");}
        }
    }
}
