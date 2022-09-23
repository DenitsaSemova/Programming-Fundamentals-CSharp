using System;

namespace P05CharacterStats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int remainingHealth = maxHealth - currHealth;
            string currHealthAsString = new string('|', currHealth);
            string remainingHealthAsString = new string('.', remainingHealth);
            string healthBar = $"Health: |{currHealthAsString}{remainingHealthAsString}|";

            Console.WriteLine(healthBar);

            int remainingEnergy = maxEnergy - currEnergy;
            string currEnergyAsString = new string('|', currEnergy);
            string remainingEnergyAsString = new string('.', remainingEnergy);

            string energyBar = $"Energy: |{currEnergyAsString}{remainingEnergyAsString}|";

            Console.WriteLine(energyBar);

            
        }
    }
}

