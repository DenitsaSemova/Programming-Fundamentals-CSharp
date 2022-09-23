using System;

namespace P04DrawAFilledSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSqare(n);           
        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string ('-', 2 * n));
        }

        static void PrintMiddleRow(int n)
        {
            Console.Write('-');

            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine('-');
        }

        static void PrintSqare(int n)
        {
            PrintHeaderRow(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }

            PrintHeaderRow(n);
        }
    }
}
