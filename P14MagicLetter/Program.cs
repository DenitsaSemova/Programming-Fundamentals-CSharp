using System;

namespace P14MagicLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char exceptLetter = char.Parse(Console.ReadLine());

            string result = "";

            for (char i = startLetter; i <= endLetter; i++)
            {
                if (i != exceptLetter)
                {
                    for (char j = startLetter; j <= endLetter; j++)
                    {
                        if (j != exceptLetter)
                        {
                            for (char l = startLetter; l <= endLetter; l++)
                            {
                                if (l != exceptLetter)
                                {
                                    result += $"{i}{j}{l} ";
                                }
                            }
                        }
                    }
                }
            }

            Console.Write($"{result} ");
        }
    }
}
