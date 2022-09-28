using System;

namespace P04NumbersInReversedOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string reversed = GetReversedInput(input);
            Console.WriteLine(reversed);
        }

        static string GetReversedInput(string input)
        {
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }

            return reversed;
        }
    }
}
