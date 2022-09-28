using System;
using System.Text;

namespace P06SumBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier == 0)
            {
                Console.WriteLine(0);
                Environment.Exit(0);
            }

            StringBuilder result = new StringBuilder();
            int remainder = 0;
            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(numAsString[i].ToString());
                
                int currSum = digit * multiplier + remainder;
                remainder = currSum / 10;
                

                result.Append(currSum % 10);
            }

            result.Append(remainder);
            string output = result.ToString().TrimEnd('0');

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }

            Console.WriteLine();
        }
    }
}
