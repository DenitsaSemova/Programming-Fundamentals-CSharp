using System;

namespace P08LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Strings are separated by one or more white spaces. -> za da ne dava greshka ako ima poveche spase-ove. 

            string[] words = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            double totalSum = 0;
            foreach (var word in words)
            {
                char first = word[0];
                char last = word[word.Length - 1];

                string numAsString = word.Substring(1, word.Length - 2);
                int num = int.Parse(numAsString);

                double sum = 0;
                if (char.IsUpper(first))
                {
                    sum += num / (first - 64.0); // taka namirame na koe mqsto v azbukata e chrez ascii

                }
                else
                {
                    sum += num * (first - 96.0);

                }

                if (char.IsUpper(last))
                {
                    sum -= (last - 64.0);

                }
                else
                {
                    sum += (last - 96.0);

                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
