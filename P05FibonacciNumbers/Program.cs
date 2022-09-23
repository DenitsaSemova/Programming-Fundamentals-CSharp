using System;

namespace P05FibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            PrintFibonacciSequence(n);
        }

        static void PrintFibonacciSequence(int n)
        {
            int fibonadcciN = 1;
            int fibMinus1 = 1;
            int fibMinus2 = 0;
            
            for (int i = 0; i < n; i++)
            {
                fibonadcciN = fibMinus2 + fibMinus1;
                fibMinus2 = fibMinus1;
                fibMinus1 = fibonadcciN;
            }

            Console.WriteLine(fibonadcciN);

        }
    }
}
