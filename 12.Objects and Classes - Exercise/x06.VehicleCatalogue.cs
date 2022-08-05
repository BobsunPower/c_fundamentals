using System;
using System.Collections.Generic;
using System.Linq;

namespace x06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {string type = cmd.Split()[0]; string model = cmd.Split()[1]; string color = cmd.Split()[2];double hp = double.Parse(cmd.Split()[3]);
                if (type == "car") {cars.Add(new Car(model, color, hp));}
                if (type == "truck") {trucks.Add(new Truck(model, color, hp));}
                cmd = Console.ReadLine();}
            string vehicle = Console.ReadLine();
            while (vehicle != "Close the Catalogue") {string modelWanted = vehicle;
                if (CarOrTruck(cars, modelWanted))
                {foreach (Car car in cars)
                    {if (car.Model == modelWanted)
                        {Console.WriteLine($@"Type: Car
Model: {car.Model}
Color: {car.Color}
Horsepower: {car.HorsePower}"); continue;}}}
                else {
                    foreach (Truck truck in trucks) {
                        if (truck.Model == modelWanted)
                        {Console.WriteLine($@"Type: Truck
Model: {truck.Model}
Color: {truck.Color}
Horsepower: {truck.HorsePower}"); continue;
                        }
                    }
                }
                vehicle = Console.ReadLine();
            }
            CarAverage(cars);
            TruckAverage(trucks);
        }
        static bool CarOrTruck(List<Car> cars, string modelWanted)
        {if (cars.Any(m => m.Model == modelWanted)) {return true;}
            return false;}
        static void CarAverage(List<Car> cars) {
            double totalCarHorsePower = 0;
            foreach (Car car in cars) {totalCarHorsePower += car.HorsePower;}
            if (cars.Count > 0) {Console.WriteLine($"Cars have average horsepower of: {totalCarHorsePower / cars.Count:f2}.");}
            else {Console.WriteLine($"Cars have average horsepower of: {0:f2}.");}}
        static void TruckAverage(List<Truck> trucks)
        {double totalTruckHorsePower = 0;
            foreach (Truck truck in trucks) {totalTruckHorsePower += truck.HorsePower;}
            if (trucks.Count > 0)
            {Console.WriteLine($"Trucks have average horsepower of: {totalTruckHorsePower / trucks.Count:f2}.");}
            else {Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");}
        }
    }
    class Car
    {
        public Car(string model, string color, double hp)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = hp;
            this.Cars = new List<Car>();
        }
        public List<Car> Cars {get; set;}
        public string Model {get; set;}
        public string Color {get; set;}
        public double HorsePower {get; set;}
    }
    class Truck
    {
        public Truck(string model, string color, double hp)
        {
            this.Model = model;
            this.Color = color;
            this.HorsePower = hp;
            this.Trucks = new List<Truck>();
        }
        public List<Truck> Trucks {get; set;}
        public string Model {get; set;}
        public string Color {get; set;}
        public double HorsePower {get; set;}
    }
}
