using System;
using System.Collections.Generic;
using System.Linq;

namespace x03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            Dictionary<string, Product> pdtPrc = new Dictionary<string, Product>();
            while (cmd != "buy") {
                string pdt = cmd.Split().ToArray()[0];
                decimal prc = decimal.Parse(cmd.Split().ToArray()[1]);
                int qty = int.Parse(cmd.Split().ToArray()[2]);
                if (!pdtPrc.ContainsKey(pdt))
                {pdtPrc.Add(pdt, new Product(pdt, prc, qty));}
                else {pdtPrc[pdt].Price = prc; pdtPrc[pdt].Quantity += qty;}
                cmd = Console.ReadLine();}
            foreach (var p in pdtPrc) {Console.WriteLine($"{p.Value.Name} -> {(p.Value.Price * p.Value.Quantity):F2}");}
        }
        class Product
        {
            public Product(string name, decimal price, int quantity)
            {
                this.Name = name;
                this.Price = price;
                this.Quantity = quantity;
            }
            public string Name {get; set;}
            public decimal Price {get; set;}
            public int Quantity {get; set;}
        }
    }
}
