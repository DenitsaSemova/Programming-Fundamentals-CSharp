using System;
using System.Collections.Generic;
using System.Linq;

namespace P03ImmuneSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = int.Parse(Console.ReadLine());
            double remainingHealth = initialHealth;
            Dictionary<string, int> defeatedViruses = new Dictionary<string, int>();

            while (true)
            {
                string virusName = Console.ReadLine();

                if (virusName == "end")
                {
                    Console.WriteLine($"Final Health: {Math.Floor(remainingHealth)}");
                    break;
                }


                int virusStrength = 0;
                int virusDefeatSeconds = 0;
                int defeatMins = 0;
                int defeatSecs = 0;

                foreach (var letter in virusName)
                {
                    virusStrength += letter;
                }

                virusStrength = (virusStrength / 3);

                if (defeatedViruses.ContainsKey(virusName))
                {
                    virusDefeatSeconds = defeatedViruses[virusName] / 3;
                }
                else
                {
                    virusDefeatSeconds = virusStrength * virusName.Length;
                    defeatedViruses.Add(virusName, virusDefeatSeconds);
                    
                }

                
                defeatMins = virusDefeatSeconds / 60;
                defeatSecs = virusDefeatSeconds % 60;

                if (remainingHealth > virusDefeatSeconds)
                {
                    remainingHealth -= virusDefeatSeconds;

                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusDefeatSeconds} seconds");
                    Console.WriteLine($"{virusName} defeated in {defeatMins}m {defeatSecs}s.");
                    Console.WriteLine($"Remaining health: {Math.Floor(remainingHealth)}");

                    remainingHealth = Math.Floor(remainingHealth * 1.2);


                    if (remainingHealth > initialHealth)
                    {
                        remainingHealth = initialHealth;
                    }
                }
                else if (remainingHealth < virusDefeatSeconds)
                {
                    Console.WriteLine($"Virus {virusName}: {virusStrength} => {virusDefeatSeconds} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }

            }
        }
    }
}
