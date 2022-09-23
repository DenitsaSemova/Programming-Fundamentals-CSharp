using System;
using System.Collections.Generic;
using System.Linq;

namespace P08LogsAggregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] tokens = line.Split();

                string iP = tokens[0];
                string user = tokens[1];
                int duration = int.Parse(tokens[2]);

                if (logs.ContainsKey(user) == false)
                {
                    logs.Add(user, new SortedDictionary<string, int>());
                }

                if (logs[user].ContainsKey(iP) == false)
                {
                    logs[user].Add(iP, duration);
                }
                else
                {
                    logs[user][iP] += duration;
                }
            }

            foreach (var user in logs)
            {
                var totalDuration = logs[user.Key].Values.Sum();
                var listOfIps = user.Value.Keys.ToList();

                Console.WriteLine($"{user.Key}: {totalDuration} [{string.Join(", ", listOfIps)}]");
            }
        }
    }
}
