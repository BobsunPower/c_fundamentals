using System;
using System.Collections.Generic;
using System.Linq;

namespace x07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (cmd != "end") {
                string type = cmd.Split('/')[0];
                string brand = cmd.Split('/')[1];
                string model = cmd.Split('/')[2];
                string wgtOrPwr = cmd.Split('/')[3];
                if (type == "Car") {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = wgtOrPwr
                    };
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = wgtOrPwr
                    };
                    trucks.Add(truck);
                }
                cmd = Console.ReadLine();
            }
            List<Car> srtCars = cars.OrderBy(brand => brand.Brand).ToList();
            List<Truck> srtTrucks = trucks.OrderBy(brand => brand.Brand).ToList();
            if (cars.Count > 0) {
                string prnt = "Cars:";
                foreach (Car car in srtCars) {prnt += $"\n{car.Brand}: {car.Model} - {car.HorsePower}hp";}
                Console.WriteLine(prnt);
            }
            if (trucks.Count > 0)
            {
                string prnt = "Trucks:";
                foreach (Truck truck in srtTrucks) {prnt += $"{truck.Brand}: {truck.Model} - {truck.Weight}kg";}
                Console.WriteLine(prnt);
            }
        }
    }
    class Car
    {
        public string Brand {get; set;}
        public string Model {get; set;}
        public string HorsePower {get; set;}
    }
    class Truck
    {
        public string Brand {get; set;}
        public string Model {get; set;}
        public string Weight {get; set;}
    }
    class Catalog
    {
        public List<Car> Cars {get; set;}
        public List<Truck> Trucks {get; set;}
    }
}
