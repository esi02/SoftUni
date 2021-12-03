using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, LikesAndComments> followers = new Dictionary<string, LikesAndComments>();

            string command = Console.ReadLine();
            while (command != "Log out")
            {
                string[] commandArgs = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string username = commandArgs[1];

                if (action == "New follower")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new LikesAndComments { likes = 0, comments = 0 });
                    }
                }
                else if (action == "Like")
                {
                    int count = int.Parse(commandArgs[2]);
                    if (followers.ContainsKey(username))
                    {
                        followers[username].likes += count;
                    }
                    else
                    {
                        followers.Add(username, new LikesAndComments { likes = count, comments = 0 });
                    }
                }
                else if (action == "Comment")
                {
                    if (followers.ContainsKey(username))
                    {
                        followers[username].comments += 1;
                    }
                    else
                    {
                        followers.Add(username, new LikesAndComments { likes = 0, comments = 1 });
                    }
                }
                else if (action == "Blocked")
                {
                    if (followers.ContainsKey(username))
                    {
                        followers.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                }

                command = Console.ReadLine();
            }
            followers = followers
                .OrderByDescending(x => x.Value.comments + x.Value.likes)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"{followers.Count} followers");

            foreach (var user in followers)
            {
                Console.WriteLine($"{user.Key}: {user.Value.comments + user.Value.likes}");
            }
        }
    }
    class LikesAndComments
    {
        public int likes { get; set; }
        public int comments { get; set; }
    }
}
