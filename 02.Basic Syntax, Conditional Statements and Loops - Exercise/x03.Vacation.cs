using System;

namespace x03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine()); string grp = Console.ReadLine(); string day = Console.ReadLine(); double mny = 0;
            if (day == "Friday") {
                switch (grp) {
                    case "Students": mny = 8.45; break;
                    case "Business": mny = 10.9; break;
                    case "Regular": mny = 15; break;}}
            else if (day == "Saturday") {
                switch (grp) {
                    case "Students": mny = 9.8; break;
                    case "Business": mny = 15.6; break;
                    case "Regular": mny = 20; break;}}
            else if (day == "Sunday") {
                switch (grp) {
                    case "Students": mny = 10.46; break;
                    case "Business": mny = 16; break;
                    case "Regular": mny = 22.5; break;}}
            if (grp == "Business" && ppl >= 100) {ppl -= 10;}
            double total = ppl * mny;
            if (grp == "Students" && ppl >= 30) {total -= total * 0.15;}
            if (grp == "Regular" && ppl >= 10 && ppl <= 20) {total -= total * 0.05;}
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
