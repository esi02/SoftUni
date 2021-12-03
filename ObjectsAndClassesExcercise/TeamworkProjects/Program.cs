using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 1; i <= countOfTeams; i++)
            {
                string[] userAndTeam = Console.ReadLine()
                    .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();


                string user = userAndTeam[0];
                string team = userAndTeam[1];


                bool doesNewTeamExist = teams
                       .Select(x => x.team).Contains(team);

                bool doesNewUserExist = teams
                    .Any(x => x.user == user);

                if (doesNewTeamExist == false && doesNewUserExist == false)
                {
                    var newTeam = new Team(user, team);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
                else if (doesNewTeamExist)
                {
                    Console.WriteLine($"Team {team} was already created!");
                }
                else if (doesNewUserExist)
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }

            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] userWithTeam = command
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string userToJoin = userWithTeam[0];
                string teamToJoin = userWithTeam[1];

                bool doesTeamExist = teams
                     .Any(x => x.team == teamToJoin);

                bool isAlreadyMember = teams
                    .Any(x => x.members.Contains(userToJoin));

                bool isCreator = teams
                    .Any(x => x.user == userToJoin);

                if (doesTeamExist && isAlreadyMember == false && isCreator == false)
                {
                    int indexOfTeam = teams
                    .FindIndex(x => x.team == teamToJoin);

                    teams[indexOfTeam].members.Add(userToJoin);
                }
                else if (doesTeamExist == false)
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else if (isCreator || isAlreadyMember)
                {
                    Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                }

                command = Console.ReadLine();
            }

            List<Team> withMembers = teams
                .Where(x => x.members.Count > 0)
                .OrderByDescending(x => x.members.Count)
                .ThenBy(x => x.team)
                .ToList();

            List<Team> withoutMembers = teams
                .Where(x => x.members.Count == 0)
                .OrderBy(x => x.team)
                .ToList();

            foreach (var team in withMembers)
            {
                Console.WriteLine(team.team);
                Console.WriteLine("- " + team.user);
                team.members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in withoutMembers)
            {
                Console.WriteLine(team.team);
            }

        }
    }
    class Team
    {
        public string user { get; set; }
        public string team { get; set; }
        public List<string> members { get; set; }
        public Team(string User, string Team)
        {
            user = User;
            team = Team;
            members = new List<string>();
        }
    }
}
