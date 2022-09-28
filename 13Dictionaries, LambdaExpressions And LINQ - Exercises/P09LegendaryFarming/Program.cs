using System;
using System.Collections.Generic;
using System.Linq;

namespace P09LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary - valid items
            //Dictionary - junk items
            //while
            //motes = MOtes
            //order by quantity in descending order
            //then order by name in ascending order 
            //junk items - ordered in alphabetical order
            //print

            Dictionary<string, int> validItems = new Dictionary<string, int>();

            validItems.Add("shards", 0);
            validItems.Add("fragments", 0);
            validItems.Add("motes", 0);

            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

            bool isRuning = true;
            while (isRuning)
            {
                string[] tokens = Console.ReadLine()
                    .ToLower()
                    .Split();

                for (int i = 0; i < tokens.Length -1; i+= 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string item = tokens[i + 1];

                    if (validItems.ContainsKey(item))
                    {
                        validItems[item] += quantity;

                        if (validItems[item] >= 250)
                        {
                            validItems[item] -= 250;
                            isRuning = false;

                            switch (item)
                            {
                                case "shards":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                            }

                            break;
                        }
                                                
                    }
                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            Dictionary<string, int> sortedItems = validItems
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var sortedItem in sortedItems)
            {
                Console.WriteLine($"{sortedItem.Key}: {sortedItem.Value}");
            }

            foreach (var junkItem in junkItems)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}
