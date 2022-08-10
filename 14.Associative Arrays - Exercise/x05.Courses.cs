using System;
using System.Collections.Generic;

namespace x05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "end") {
                string crs = cmd.Split(" : ")[0]; string std = cmd.Split(" : ")[1];
                if (!courses.ContainsKey(crs))
                {courses.Add(crs, new List<string>());}
                courses[crs].Add(std);}
            foreach (var c in courses)
            {Console.WriteLine($"{c.Key}: {c.Value.Count}");
                foreach (var s in c.Value)
                {Console.WriteLine($"-- {s}");}
            }
        }
    }
}
