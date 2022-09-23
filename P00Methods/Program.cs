using System;

namespace P1BlankReceipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());

            PrintReceipt(symbol, number);
        }

        static void PrintReceipt(char gosho, int count)
        {
            PrintHeader(gosho, count);
            
        }

        static void PrintHeader(char gosho, int count)
        {
            Console.WriteLine("CASH RECEIPT" + Environment.NewLine + new string(gosho, count));
        }
    }
}
