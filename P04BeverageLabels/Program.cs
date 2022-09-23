using System;

namespace P04BeverageLabels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double energy = volume * energyContent / 100.0;
            double sugar = volume * sugarContent / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy:f2}kcal, {sugar:f2}g sugars");
        }
    }
}
