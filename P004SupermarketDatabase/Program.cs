using System;
using System.Collections.Generic;
using System.Linq;

namespace P04SupermarketDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, int>> products = new Dictionary<string, Dictionary<double, int>>();

            double grandTotal = 0;

            string line = Console.ReadLine();
            while (line != "stocked")
            {
                string[] tokens = line.Split();

                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                if (products.ContainsKey(name) == false)
                {
                    products.Add(name, new Dictionary<double, int>());
                }

                if (products[name].ContainsKey(price) == false)
                {
                    products[name].Add(price, quantity);
                }
                else if (products[name].ContainsKey(price) == true)
                {

                    products[name][price] += quantity;
                }

                line = Console.ReadLine();
            }

            foreach (var product in products)
            {
                string name = product.Key;
                double price = product.Value.Keys.Last();
                int quantity = product.Value.Values.Sum();
                grandTotal += (quantity * price);

                Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
