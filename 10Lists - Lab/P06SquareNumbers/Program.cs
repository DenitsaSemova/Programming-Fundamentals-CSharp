using System;
using System.Collections.Generic;
using System.Linq;

namespace P06SquareNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> squares = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int curr = numbers[i];

                double square = Math.Sqrt(curr);
                int whole = (int)square;

                if (square == whole)
                {
                    squares.Add(curr);
                }
                
            }

            squares.Sort();
            squares.Reverse();

            Console.WriteLine(String.Join(" ", squares));
        }
    }
}
