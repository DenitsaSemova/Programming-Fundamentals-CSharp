using System;

namespace P09CountTheIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            
            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    int number = int.Parse(input);
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine(counter);
                    break;
                }
            }
        }
    }
}
