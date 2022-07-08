using System;

namespace x05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usr = Console.ReadLine(); string pwd = ""; int ctr = 0;
            for (int i = usr.Length - 1; i > -1; i--) {pwd += usr[i];}
            while (true) {ctr++; string input = Console.ReadLine();
                if (input == pwd) {Console.WriteLine($"User {usr} logged in."); break;}
                if (ctr == 4) { Console.WriteLine($"User {usr} blocked!"); break; }
                Console.WriteLine("Incorrect password. Try again.");}            
        }
    }
}
