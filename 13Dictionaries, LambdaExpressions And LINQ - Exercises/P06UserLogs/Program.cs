using System;
using System.Collections.Generic;

namespace P06UserLogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userAndIP = new SortedDictionary<string, Dictionary<string, int>>();

            int ipCounter = 1;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ', '=');

                string iP = tokens[1];
                string userName = tokens[5];


                if (userAndIP.ContainsKey(userName) == false)
                {
                    userAndIP.Add(userName, new Dictionary<string, int>());
                }

                if (userAndIP[userName].ContainsKey(iP) == false)
                {
                    userAndIP[userName].Add(iP, ipCounter);
                }
                else
                {
                    userAndIP[userName][iP]++;
                }

            }

            foreach (KeyValuePair<string, Dictionary<string, int>> user in userAndIP)
            {

                Console.WriteLine(user.Key + ": ");

                int count = user.Value.Count;
                foreach (KeyValuePair<string, int> ip in user.Value)
                {
                    count--;
                    if (count > 0)
                    {

                        Console.Write($"{ip.Key} => {ip.Value}, ");
                    }
                    else
                    {
                        Console.Write($"{ip.Key} => {ip.Value}. ");

                    }

                }

                Console.WriteLine();

            }

        }
    }
}
