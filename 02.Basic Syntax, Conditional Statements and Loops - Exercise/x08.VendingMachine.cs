using System;

namespace x08.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine(); double sum = 0;
            while (cmd != "Start") {double cns = double.Parse(cmd);
                if (cns == 2) {sum += cns;}
                else if (cns == 1) {sum += cns;}
                else if (cns == 0.5) {sum += cns;}
                else if (cns == 0.2) {sum += cns;}
                else if (cns == 0.1) {sum += cns;}
                else {Console.WriteLine($"Cannot accept {cns}");}
                cmd = Console.ReadLine();}
            bool vld = true; cmd = Console.ReadLine();
            while (cmd != "End") {double prc = 0; string pdt; pdt = cmd.ToLower();
                switch (pdt) {
                    case "nuts": prc = 2; break;
                    case "water": prc = 0.7; break;
                    case "crisps": prc = 1.5; break;
                    case "soda": prc = 0.8; break;
                    case "coke": prc = 1; break;
                    default: Console.WriteLine("Invalid product"); vld = false; break;}
                if (prc > sum) {Console.WriteLine("Sorry, not enough money");}
                else if (vld == true) {Console.WriteLine($"Purchased {pdt}"); sum -= prc;}
                cmd = Console.ReadLine();}
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
