
using System;

namespace P06TriplesOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = (char)(int.Parse(Console.ReadLine()) + 'a'); 

            for (char i = 'a'; i < input; i++)
            {
                for (char j = 'a'; j < input; j++)
                {
                    for (char k = 'a'; k < input; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
