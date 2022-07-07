using System;

namespace x07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int tkt = 0;
            if (age < 0 || age > 122) {Console.WriteLine("Error!"); return;}
            else if (0 <= age && age <= 18) {
                switch (day) {
                    case "Weekday": tkt = 12; break;
                    case "Weekend": tkt = 15; break;
                    case "Holiday": tkt = 5; break;}}
            else if (18 < age && age <= 64) {
                switch (day) {
                    case "Weekday": tkt = 18; break;
                    case "Weekend": tkt = 20; break;
                    case "Holiday": tkt = 12; break;}}
            else if (64 < age && age <= 122) {
                switch (day) {
                    case "Weekday": tkt = 12; break;
                    case "Weekend": tkt = 15; break;
                    case "Holiday": tkt = 10; break;}}
            Console.WriteLine($"{tkt}$");
        }
    }
}
