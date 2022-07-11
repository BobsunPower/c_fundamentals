using System;

namespace x09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabers = double.Parse(Console.ReadLine()) * Math.Ceiling(students + (students * 0.1));
            double robes = double.Parse(Console.ReadLine()) * students;
            double belts = double.Parse(Console.ReadLine()) * (students - (students / 6));
            double expenses = sabers + robes + belts;
            if (expenses <= budget) {Console.WriteLine($"The money is enough - it would cost {expenses:f2}lv.");}
            else {Console.WriteLine($"John will need {expenses - budget:f2}lv more.");}
        }
    }
}
