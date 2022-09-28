using System;

namespace P09CountTheIntegers__TryParse_
{
    internal class Program
    {
        static void Main(string[] args)
        {          
          
            int counter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                bool isNUm = int.TryParse(input, out int number);

                if (isNUm)
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine(counter);
                    break; 
                }
            }
        }
    }
}
