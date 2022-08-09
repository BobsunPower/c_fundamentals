using System;
using System.Collections.Generic;

namespace x04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> pkg = new Dictionary<string, string>();
            for (int i = 0; i < n; i++) {
                string[] data = Console.ReadLine().Split(); string cmd = data[0]; string usr = data[1];
                if (cmd == "register")
                {string num = data[2];
                    if (pkg.ContainsKey(usr)) {Console.WriteLine($"ERROR: already registered with plate number {num}"); continue;}
                    pkg.Add(usr, num);
                    Console.WriteLine($"{usr} registered {num} successfully");}
                if (cmd == "unregister") {
                    if (!pkg.ContainsKey(usr))
                    {Console.WriteLine($"ERROR: user {usr} not found"); continue;}
                    pkg.Remove(usr);
                    Console.WriteLine($"{usr} unregistered successfully");}}
            foreach (var car in pkg)
            {Console.WriteLine($"{car.Key} => {car.Value}");}
        }
    }
}
