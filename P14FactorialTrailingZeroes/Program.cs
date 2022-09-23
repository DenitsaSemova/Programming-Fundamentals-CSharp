using System;
using System.Numerics;

namespace P13Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = GetTrailingZeroes(n);
            Console.WriteLine(result);

        }

        static BigInteger GetTrailingZeroes(BigInteger n)
        {
            BigInteger getZeroes = GetFactorial(n);
            BigInteger count = 0;

            while (getZeroes % 10 == 0)
            {
                count++;
                getZeroes /= 10;

            }

            return count;
        }

        static BigInteger GetFactorial(BigInteger n)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
