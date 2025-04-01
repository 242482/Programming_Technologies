using Project_0.Data;
using Project_0.Logic;
using System;

namespace Project_0.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Data and Logic layers
            var dataLayer = new DataLayer();
            var logicLayer = new LogicLayer(dataLayer);

            // Introduction
            Console.WriteLine("Welcome to the Shop!");
            Console.WriteLine("Here You can add items, check if tey exist or print them all!");

            bool exit = false;
            while (!exit)
            {
                // Display menu to the user
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Check if an item exists");
                Console.WriteLine("3. Print all items");
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add item
                        Console.WriteLine("Enter the item name to add:");
                        string itemToAdd = Console.ReadLine();
                        logicLayer.AddItemToStore(itemToAdd);
                        break;

                    case "2":
                        // Check if item exists
                        Console.WriteLine("Enter the item name to check:");
                        string itemToCheck = Console.ReadLine();
                        bool exists = logicLayer.DoesItemExist(itemToCheck);
                        Console.WriteLine(exists ? $"The item '{itemToCheck}' exists." : $"The item '{itemToCheck}' does not exist.");
                        break;

                    case "3":
                        // Print all items
                        var items = logicLayer.GetItems();
                        Console.WriteLine("All items in the store:");
                        if (items.Count == 0)
                        {
                            Console.WriteLine("No items found.");
                        }
                        else
                        {
                            foreach (var item in items)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;

                    case "4":
                        // Exit
                        Console.WriteLine("Exiting the application.");
                        exit = true;
                        break;

                    default:
                        // Invalid input
                        Console.WriteLine("Invalid option. Please choose option 1-4.");
                        break;

                }



                Console.ReadKey(); // To keep the console open
            }
        }
    }
}
