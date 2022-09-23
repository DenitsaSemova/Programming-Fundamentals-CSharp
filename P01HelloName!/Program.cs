using System;

namespace P01HelloName_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            
            PrintHelloName(name);
        }

        static void PrintHelloName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}
