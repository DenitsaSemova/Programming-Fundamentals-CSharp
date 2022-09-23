﻿using System;

namespace P1BlankReceipt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintFooter()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9" + " " + "SoftUni");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________"); 
            Console.WriteLine("Received by___________________"); 
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
