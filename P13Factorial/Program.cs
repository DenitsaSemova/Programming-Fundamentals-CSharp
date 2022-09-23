using System;
using System.Numerics;

namespace P13Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = GetFactorial(n);
            Console.WriteLine(result);

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
