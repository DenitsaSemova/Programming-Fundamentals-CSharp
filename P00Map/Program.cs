using System;
using System.Collections.Generic;

namespace P00Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //country - town
            //country - town : street
            //country - town : street # 12
            // END

            var map = new Dictionary<string, Dictionary<string, Dictionary<string, int>>>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                if (command.Contains(" - "))
                {
                    var tokens = command.Split(" - ");
                    string country = tokens[0];
                    string town = tokens[1];

                    if (map.ContainsKey(country) == false)
                    {
                        map.Add(country, new Dictionary<string, Dictionary<string, int>>());
                    }

                    if (map[country].ContainsKey(town) == false)
                    {
                        map[country].Add(town, new Dictionary<string, int>());
                    }
                }
            }
        }
    }
}
