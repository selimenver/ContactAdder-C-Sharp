using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> contacts = new List<string>();

        while (true)
        {
            Console.WriteLine("Welcome to Contacts App");
            Console.WriteLine("1. View contacts");
            Console.WriteLine("2. Add a contact");
            Console.WriteLine("3. Exit");
            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (contacts.Count == 0)
                {
                    Console.WriteLine("No contacts yet.");
                }
                else
                {
                    Console.WriteLine("Your Contacts");
                    foreach (string contact in contacts)
                    {
                        Console.WriteLine(contact);
                    }
                }
            }

            else if (choice == "2")
            {
                Console.Write("Contact's Name:");
                string Name = Console.ReadLine();
                Console.Write("Contact's Phone Number:");
                string Number = Convert.ToString(Console.ReadLine());
                contacts.Add(Name + " - " + Number);
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}