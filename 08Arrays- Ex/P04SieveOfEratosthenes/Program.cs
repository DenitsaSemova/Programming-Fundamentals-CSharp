using System;

namespace P04SieveOfEratosthenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine()); //6

            bool[] primeValues = new bool[endNumber + 1]; //7

            for (int i = 0; i < primeValues.Length; i++)
            {
                primeValues[i] = true;
            }

            primeValues[0] = false;
            primeValues[1] = false;

            for (int i = 2; i < primeValues.Length; i++)
            {
                if (primeValues[i])
                {
                    Console.Write($"{i} ");

                    for (int j = 2 * i; j < primeValues.Length; j += i)
                    {
                        primeValues[j] = false;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
