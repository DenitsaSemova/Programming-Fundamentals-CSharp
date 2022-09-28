using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace P05RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double rounded = Math.Round(numbers[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers[i]} => {rounded}");
            }
        }

    }
}
