using System;
using System.Collections.Generic;

namespace x04.Students
{  

    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine(); List<Student> stds = new List<Student>();
            while (cmd != "end") {
                string fst = cmd.Split()[0]; string lst = cmd.Split()[1]; string age = cmd.Split()[2]; string twn = cmd.Split()[3];
                Student std = new Student(fst, lst, age, twn); stds.Add(std);
                cmd = Console.ReadLine();}
            string cty = Console.ReadLine();
            List<Student> srtLst = stds.FindAll(std => std.Town == cty);
            foreach (var std in srtLst) {Console.WriteLine($"{std.FirstName} {std.LastName} is {std.Age} years old.");}
        }
    }
    class Student
    {
        public Student(string fst, string lst, string age, string twn)
        {
            this.FirstName = fst; this.LastName = lst; this.Age = age; this.Town = twn;
        }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Age {get; set;}
        public string Town {get; set;}
    }
}
