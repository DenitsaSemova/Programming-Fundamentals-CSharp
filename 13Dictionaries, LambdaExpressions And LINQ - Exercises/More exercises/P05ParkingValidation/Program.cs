using System;
using System.Collections.Generic;
using System.Linq;

namespace P05ParkingValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> registered = new Dictionary<string, string>();

            string username = "";
            string licensePlateNumber = "";

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split();


                if (parts[0] == "register")
                {
                    username = parts[1];
                    licensePlateNumber = parts[2];

                    bool isValidPlate = licensePlateNumber.Length == 8
                        && char.IsUpper(licensePlateNumber[0])
                        && char.IsUpper(licensePlateNumber[1])
                        && char.IsUpper(licensePlateNumber[6])
                        && char.IsUpper(licensePlateNumber[7])
                        && char.IsDigit(licensePlateNumber[2])
                        && char.IsDigit(licensePlateNumber[3])
                        && char.IsDigit(licensePlateNumber[4])
                        && char.IsDigit(licensePlateNumber[5]);

                    if (registered.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");

                    }
                    else if (isValidPlate == false)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                    }
                    else if (registered.ContainsValue(licensePlateNumber))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                    }
                    else if (registered.ContainsKey(username) == false)
                    {
                        registered.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }


                }
                else if (parts[0] == "unregister")
                {

                    username = parts[1];

                    if (registered.ContainsKey(username) == false)
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else if (true)
                    {
                        registered.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }

                }
            }

            foreach (var user in registered)
            {

                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}
