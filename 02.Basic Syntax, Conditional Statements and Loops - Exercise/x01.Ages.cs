using System;

namespace x01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine()); string psn = "";
            if (age >= 0 && age <= 2) {psn = "baby";}
            else if (age <= 13) {psn = "child";}
            else if (age <= 19) {psn = "teenager";}
            else if (age <= 65) {psn = "adult";}
            else if (age >= 66) {psn = "elder";}
            Console.WriteLine($"{psn}");
        }
    }
}
