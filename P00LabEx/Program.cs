using System;
using System.Collections.Generic;

namespace P00LabEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook["Pesho"] = "74692388";
            phoneBook["Gosho"] = "635473645";

            phoneBook["Pesho"] = "assadasd";
            phoneBook.Add("Mimi", "1231231312");

            var name = "Pesho";
            var value = "SomeTel";

            if (phoneBook.ContainsKey(name) == false)
            {
                phoneBook.Add(name, "");
            }

            phoneBook[name] = value;
            //ako iskame da dobavqme
            //phoneBook[name] += value;

            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Key} : {contact.Value}");
            }

            //foreach (var key in phoneBook.Keys)
            //{
            //    Console.WriteLine($"{key}");
            //}

            //foreach (var val in phoneBook.Values)
            //{
            //    Console.WriteLine($"{val}");
            //}

        }
    }
}
