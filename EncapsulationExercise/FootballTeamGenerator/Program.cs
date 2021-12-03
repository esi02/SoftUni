using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Team> teams = new List<Team>();

            while (command != "END")
            {
                string[] commandArgs = command.Split(";");
                string action = commandArgs[0];

                if (action == "Team")
                {
                    string name = commandArgs[1];
                    try
                    {
                        Team team = new Team(name);
                        teams.Add(team);
                    }
                    catch (Exception ee)
                    {
                        Console.WriteLine(ee.Message);
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "Add")
                {
                    string teamName = commandArgs[1];
                    string playerName = commandArgs[2];
                    int endurance = int.Parse(commandArgs[3]);
                    int sprint = int.Parse(commandArgs[4]);
                    int dribble = int.Parse(commandArgs[5]);
                    int passing = int.Parse(commandArgs[6]);
                    int shooting = int.Parse(commandArgs[7]);
                    if (!teams.Exists(x => x.Name == teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        command = Console.ReadLine();
                        continue;
                    }
                    Player player = null;
                    try
                    {
                        player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                    }
                    catch (Exception ae)
                    {
                        Console.WriteLine(ae.Message);
                        command = Console.ReadLine();
                        continue;
                    }

                    var team = teams.Find(x => x.Name == teamName);
                    team.AddPlayer(player);

                }
                else if (action == "Remove")
                {
                    string teamName = commandArgs[1];
                    string playerName = commandArgs[2];
                    if (!teams.Exists(x => x.Name == teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var team = teams.Find(x => x.Name == teamName);
                        team.RemovePlayer(playerName);
                    }

                }
                else if (action == "Rating")
                {
                    string teamName = commandArgs[1];
                    if (!teams.Exists(x => x.Name == teamName))
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                        command = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        var team = teams.Find(x => x.Name == teamName);
                        Console.WriteLine($"{team.Name} - {team.Rating:f0}");
                    }
                }


                command = Console.ReadLine();
            }
        }
    }
}
