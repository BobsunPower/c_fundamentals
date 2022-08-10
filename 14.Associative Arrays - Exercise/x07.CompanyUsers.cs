using System;
using System.Collections.Generic;

namespace x07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {string co = cmd.Split(" -> ")[0]; string id = cmd.Split(" -> ")[1];
                if (!users.ContainsKey(co))
                {users.Add(co, new List<string>());}
                if (users[co].Contains(id))
                {continue;}
                users[co].Add(id);}
            foreach (var usr in users)
            {Console.WriteLine(usr.Key);
                foreach (var id in usr.Value)
                {Console.WriteLine($"-- {id}");}
            }
        }
    }
}
