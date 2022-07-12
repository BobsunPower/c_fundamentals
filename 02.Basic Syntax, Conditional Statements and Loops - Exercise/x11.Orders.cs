using System;

namespace x11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); double total = 0;
            for (int i = 1; i <= n; i++) {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double sum = (days * capsules) * price;
                total += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");}
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
