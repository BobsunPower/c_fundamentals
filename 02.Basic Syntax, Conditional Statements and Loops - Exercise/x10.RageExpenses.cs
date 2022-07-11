using System;

namespace x10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int losses = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headset = 0; int mouse = 0; int keyboard = 0; int display = 0; int ctr = 0;
            for (int i = 1; i <= losses; i++) {
                if (i % 2 == 0) {headset++;}
                if (i % 3 == 0) {mouse++;}
                if (i % 2 == 0 && i % 3 == 0) {keyboard++; ctr++;}
                if (ctr % 2 == 0 && ctr > 0) {display++; ctr = 0;}}
            Console.WriteLine($"Rage expenses: {(headset * headsetPrice) + (mouse * mousePrice) + (keyboard * keyboardPrice) + (display * displayPrice):f2} lv.");
        }
    }
}
