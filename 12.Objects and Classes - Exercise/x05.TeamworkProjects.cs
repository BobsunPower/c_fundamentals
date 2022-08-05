using System;
using System.Collections.Generic;
using System.Linq;

namespace x05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            RegisterTeam(teams, n);
            JoiningTeam(teams);
            List<Team> teamWithMembers = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            List<Team> teamsToDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            foreach (Team validTeams in teamWithMembers)
            {Console.WriteLine($"{validTeams.Name}\n- {validTeams.Creator}");
                foreach (string currMember in validTeams.Members.OrderBy(m => m))
                {Console.WriteLine($"-- {currMember}");}}
            Console.WriteLine($"Teams to disband:");
            foreach (Team invalidTeam in teamsToDisband)
            {Console.WriteLine($"{invalidTeam.Name}");}
        }
        static void RegisterTeam(List<Team> teams, int teamsCount)
        {
            for (int i = 0; i < teamsCount; i++)
            {string[] cmd = Console.ReadLine().Split('-'); string name = cmd[1]; string creator = cmd[0];
                if (teams.Any(t => t.Name == name)) {Console.WriteLine($"Team {name} was already created!"); continue;}
                if (teams.Any(c => c.Creator == creator)) {Console.WriteLine($"{creator} cannot create another team!"); continue;}
                teams.Add(new Team(name, creator));
                Console.WriteLine($"Team {name} has been created by {creator}!");}
        }
        static void JoiningTeam(List<Team> teams)
        {
            string cmd;
            while ((cmd = Console.ReadLine()) != "end of assignment")
            {string memberName = cmd.Split("->")[0]; string teamName = cmd.Split("->")[1];
                Team joinTeam = teams.FirstOrDefault(t => t.Name == teamName);
                if (joinTeam == null) {Console.WriteLine($"Team {teamName} does not exist!"); continue;}
                bool alreadyMember = false;
                foreach (Team team in teams) {
                    if (team.Members.Contains(memberName)) {alreadyMember = true;}}
                if (alreadyMember)
                {Console.WriteLine($"Member {memberName} cannot join team {teamName}!"); continue;}
                if (teams.Any(c => c.Creator == memberName))
                {Console.WriteLine($"Member {memberName} cannot join team {teamName}!"); continue;}
                joinTeam.AddMember(memberName);
            }
        }
    }
    class Team
    {
        public Team(string teamName, string teamCreator)
        {
            this.Name = teamName;
            this.Creator = teamCreator;
            this.Members = new List<string>();
        }
        public string Name {get; set;}
        public string Creator {get; set;}
        public List<string> Members {get; set;}
        public void AddMember(string member)
        {this.Members.Add(member);}
    }
}
