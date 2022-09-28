using System;
using System.Collections.Generic;
using System.Linq;

namespace P05HandsOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read input
            //extract player and cards
            //store player and cards
            //powers Dictionary
            //distinct cards for each player
            //player points
            //print the result

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            // imame List<string>, zashtoto ne znaem kolko puti shte sreshtnem daden igrach i pri powtorno sreshtane, shte dobavqme kartite v spisuka.

            while (true)
            {
                string line = Console.ReadLine();
                
                if (line == "JOKER")
                {
                    break;
                }

                string[] tokens = line.Split(":");

                string playerName = tokens[0];
                string[] cards = tokens[1].Trim().Split(", ");

                if (players.ContainsKey(playerName) == false)
                {
                    players.Add(playerName, new List<string>());
                }

                players[playerName].AddRange(cards);
            }

            Dictionary<string, int> powers = new Dictionary<string, int>();

            for (int i = 2; i <= 9; i++)
            {
                powers.Add(i.ToString(), i);
            }
            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);

            powers.Add("1", 10);
            powers.Add("S", 4);
            powers.Add("H", 3);
            powers.Add("D", 2);
            powers.Add("C", 1);

            foreach (var player in players)
            {
                List<string> cards = player.Value.Distinct().ToList();

                int sum = 0;

                foreach (var card in cards)
                {
                    string cardPowerStr = card[0].ToString();
                    string cardSuitStr = card[card.Length - 1].ToString();

                    int cardPower = powers[cardPowerStr];
                    int cardSuit = powers[cardSuitStr];

                    sum += cardPower * cardSuit;
                }

                Console.WriteLine($"{player.Key}: {sum}");
            }
        }
    }
}
