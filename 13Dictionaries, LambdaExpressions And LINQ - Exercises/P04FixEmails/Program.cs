using System;
using System.Collections.Generic;

namespace P04FixEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                string email = Console.ReadLine();

                //if (email.EndsWith(".us") || email.EndsWith(".uk") == false)
                if(!email.EndsWith("us") || email.EndsWith("uk"))
                {
                    contacts.Add(name, email);
                }

            }
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine($"{contact.Key} -> {contact.Value}");
                }

        }
    }
}
