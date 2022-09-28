using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P07AndreyAndBilliard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');

                string prodName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                Product product = products.FirstOrDefault(p => p.Name == prodName);

                if (product == null)
                {
                    Product newProduct = new Product(prodName, price);
                    products.Add(newProduct);
                }
                else
                {
                    product.Price = price;
                }
            }

            List<Customer> customers = new List<Customer>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of clients")
                {
                    break;
                }

                string[] tokens = line.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string customerName = tokens[0];
                string prodName = tokens[1];
                int prodQuantity = int.Parse(tokens[2]);

                if (!products.Any(p => p.Name == prodName))
                {
                    continue;
                }

                Customer customer = customers
                    .FirstOrDefault(c => c.Name == customerName);

                if (customer == null)
                {
                    Customer newCustomer = new Customer(customerName);
                    newCustomer.OrderedProducts.Add(prodName, prodQuantity);
                    customers.Add(newCustomer);
                }
                else
                {
                    if (customer.OrderedProducts.ContainsKey(prodName) == false)
                    {
                        customer.OrderedProducts.Add(prodName, prodQuantity);
                    }
                    else
                    {
                        customer.OrderedProducts[prodName] += prodQuantity;
                    }
                }
            }

            decimal totalBill = 0;

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                Console.WriteLine(customer.Name);
                decimal bill = 0;

                foreach (var orderedProduct in customer.OrderedProducts)
                {
                    Console.WriteLine($"-- {orderedProduct.Key} - {orderedProduct.Value}");

                    string productName = orderedProduct.Key;
                    int quantity = orderedProduct.Value;

                    decimal price = products.First(p => p.Name == productName).Price;

                    bill += quantity * price;
                }

                totalBill += bill;
                
                Console.WriteLine($"Bill: {bill:f2}");
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Customer
    {
        public Customer(string name)
        {
            this.Name = name;
            this.OrderedProducts = new Dictionary<string, int>();
        }

        public string Name { get; set; }
        public Dictionary<string, int> OrderedProducts { get; set; }
    }
}
