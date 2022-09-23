using System;

namespace P07CakeIngredients
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRuning = true;

            int ingredientsCounter = 0;

            while (isRuning)
            {
                string inputIngredient = Console.ReadLine();

                if (inputIngredient == "Bake!")
                {
                    isRuning = false;
                }
                else
                {
                    ingredientsCounter++;
                    Console.WriteLine($"Adding ingredient {inputIngredient}.");
                }
            }

            Console.WriteLine($"Preparing cake with {ingredientsCounter} ingredients.");
        }
    }
}
