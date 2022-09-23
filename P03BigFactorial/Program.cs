using System;
using System.Numerics;

namespace P03BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}
