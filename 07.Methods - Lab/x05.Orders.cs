using System;

namespace x05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine(); int qty = int.Parse(Console.ReadLine());
            OrderPrice(cmd, qty);
        }
        private static void OrderPrice(string name, int num)
        {
            double res = 0;
            switch (name) {
                case "coffee": res = num * 1.50; break;
                case "water": res = num * 1.00; break;
                case "snacks": res = num * 2.00; break;
                case "coke": res = num * 1.40; break;}
            Console.WriteLine($"{res:f2}");
        }
    }
}
