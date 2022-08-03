using System;
using System.Collections.Generic;
using System.Linq;

namespace x06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            List<Item> items = new List<Item>();
            while (cmd != "end") {
                string srlNum = cmd.Split()[0];
                string item = cmd.Split()[1];
                int qtyItem = int.Parse(cmd.Split()[2]);
                decimal price = decimal.Parse(cmd.Split()[3]);
                Item newItem = new Item()
                {Name = item, Price = price};
                items.Add(newItem);
                Box newBox = new Box()
                {
                    SerialNumber = srlNum,
                    Item = newItem,
                    ItemQuantity = qtyItem,
                    PriceBox = qtyItem * newItem.Price
                };
                boxes.Add(newBox);
                cmd = Console.ReadLine();
            }
            List<Box> fltr = boxes.OrderByDescending(box => box.PriceBox).ToList();
            foreach (Box box in fltr) {                
                Console.WriteLine($@"{box.SerialNumber}
-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}
-- ${box.PriceBox:f2}");
            }
        }
    }
    class Item
    {
        public string Name {get; set;}
        public decimal Price {get; set;}
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber {get; set;}
        public Item Item {get; set;}
        public int ItemQuantity {get; set;}
        public decimal PriceBox {get; set;}
    }
}
