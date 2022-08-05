using System;
using System.Collections.Generic;
using System.Linq;

namespace x04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++) {
                string[] data = Console.ReadLine().Split(' ');
                students.Add(new Student(data[0], data[1], double.Parse(data[2])));}
            students = students.OrderByDescending(g => g.Grade).ToList();
            foreach (Student student in students) {Console.WriteLine(student);}
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public double Grade {get; set;}
        public override string ToString()
        {return $"{FirstName} {LastName}: {Grade:f2}";}
    }
}
