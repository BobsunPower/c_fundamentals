using System;
using System.Collections.Generic;

namespace x05.Students2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine(); List<Student> stds = new List<Student>();
            while (cmd != "end") {
                string fst = cmd.Split()[0]; string lst = cmd.Split()[1]; string age = cmd.Split()[2]; string twn = cmd.Split()[3];
                if (ExistCheck(stds, fst, lst)) {Student sts = GetStudent(stds, fst, lst); sts.Age = age; sts.Town = twn;}
                else {Student student = new Student(fst, lst, age, twn); stds.Add(student);}
                cmd = Console.ReadLine();}
            string cty = Console.ReadLine();
            List<Student> srtLst = stds.FindAll(std => std.Town == cty);
            foreach (Student student in srtLst) {Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");}
        }
        private static Student GetStudent(List<Student> stds, string fst, string lst)
        {
            Student xst = null;
            foreach (Student std in stds) {
                if (std.FirstName == fst && std.LastName == lst) {xst = std;}}
            return xst;
        }

        private static bool ExistCheck(List<Student> stds, string fst, string lst)
        {
            foreach (Student std in stds) {if (std.FirstName == fst && std.LastName == lst) {return true;}}
            return false;
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
