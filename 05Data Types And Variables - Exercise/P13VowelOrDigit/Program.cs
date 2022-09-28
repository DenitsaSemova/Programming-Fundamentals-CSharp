
using System;

namespace P13VowelOrDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' ||
                symbol == 'o' ||
                symbol == 'e' ||
                symbol == 'y' ||
                symbol == 'i' ||
                symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(symbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
