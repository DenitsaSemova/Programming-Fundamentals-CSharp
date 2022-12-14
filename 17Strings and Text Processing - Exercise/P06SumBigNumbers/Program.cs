using System;
using System.Text;

namespace P06SumBigNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int maxLength = Math.Max(num1.Length, num2.Length);

            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            StringBuilder result = new StringBuilder();
            int remainder = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int firstDigit = int.Parse(num1[i].ToString());
                int secondDigit = int.Parse(num2[i].ToString());

                int currSum = firstDigit + secondDigit + remainder;
                remainder = 0;
                if (currSum > 9)
                {
                    currSum -= 10;
                    remainder++;
                }

                result.Append(currSum);
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
