using System;

namespace P15FastPrimeChecker_Refactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int currNumber = 2; currNumber <= endNumber; currNumber++)
            {
                bool isPrime = true;

                for (int divider = 2; divider <= Math.Sqrt(currNumber); divider++)
                {
                    if (currNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currNumber} -> {isPrime}");
            }
        }
    }
}
