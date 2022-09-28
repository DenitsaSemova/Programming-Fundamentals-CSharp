using System;
using System.Collections.Generic;
using System.Linq;

namespace P5LadyBug
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];

            List<int> indexLadybug = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i >= 0 && i < size)
                .ToList();

            foreach (var index in indexLadybug)
            {
                field[index] = 1;
            }

            string line;

            while (true)
            {
                line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split().ToArray();

                int startIndex = int.Parse(tokens[0]);
                string direction = tokens[1];
                int flyLength = int.Parse(tokens[2]);

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                if (startIndex < 0 || startIndex >= size)
                {
                    continue;
                }

                if (field[startIndex] == 0)
                {
                    continue;
                }

                field[startIndex] = 0;
                int nextIndex = startIndex;

                while (true)
                {
                    nextIndex += flyLength;

                    if (nextIndex < 0 || nextIndex >= size)
                    {
                        break;
                    }

                    if (field[nextIndex] == 1)
                    {
                        continue;
                    }

                    field[nextIndex] = 1;
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}