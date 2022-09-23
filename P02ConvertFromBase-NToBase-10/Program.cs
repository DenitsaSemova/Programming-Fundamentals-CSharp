using System;
using System.Numerics;

namespace P02ConvertFromBase_NToBase_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();

            int @base = int.Parse(tokens[0]);

            string numAsString = tokens[1];

            BigInteger sum = 0;
            int pow = 0;
            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                char currChar = numAsString[i];
                int currNum = int.Parse(currChar.ToString());

                BigInteger currSum = currNum * BigInteger.Pow(@base, pow);
                sum += currSum;
                pow++;

            }

            Console.WriteLine(sum);

        }
    }
}
