using System;
using System.Collections.Generic;
using System.Linq;

namespace x07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            List<Person> psn = new List<Person>();
            while (cmd != "End")
            {string name = cmd.Split()[0]; string id = cmd.Split()[1]; int age = int.Parse(cmd.Split()[2]);
                foreach (Person p in psn)
                {if (psn.Any(x => x.Id == id))
                    {p.Name = name; p.Age = age; continue;}}
                psn.Add(new Person(name, id, age));
                cmd = Console.ReadLine();}
            psn = psn.OrderBy(a => a.Age).ToList();
            foreach (Person p in psn) {Console.WriteLine(p);}
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            this.Persons = new List<Person>();
        }
        public List<Person> Persons {get; set;}
        public string Name {get; set;}
        public string Id {get; set;}
        public int Age {get; set;}
        public override string ToString()
        {return $"{Name} with ID: {Id} is {Age} years old.";}
    }
}
