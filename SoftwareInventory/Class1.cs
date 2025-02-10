using System;
using System.Collections.Generic;

namespace SoftwareInventory
{
    class Product
    {
        Dictionary<string, int> dictlist = new Dictionary<string, int>();
        HashSet<string> defectiveProducts = new HashSet<string>(); 
        public void addproduct()
        {
            Console.WriteLine("Enter the name of the product:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the quantity of the product:");
            if (int.TryParse(Console.ReadLine(), out int quantity))
            {
                if (dictlist.ContainsKey(name))
                {
                    dictlist[name] += quantity; 
                    Console.WriteLine($"Updated {name}: New quantity = {dictlist[name]}");
                }
                else
                {
                    dictlist.Add(name, quantity);
                    Console.WriteLine($"Added {name} to inventory.");
                }
            }
            else
            {
                Console.WriteLine("Invalid quantity input. Please enter a valid number.");
            }
        }

        public void removeproduct()
        {
            Console.WriteLine("Enter the name of the product to remove:");
            string name = Console.ReadLine();

            if (dictlist.ContainsKey(name))
            {
                dictlist.Remove(name);
                Console.WriteLine($"{name} removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{name} does not exist in inventory.");
            }
        }

        public void updatequantity()
        {
            Console.WriteLine("Enter the name of the software:");
            string name = Console.ReadLine();

            if (dictlist.ContainsKey(name))
            {
                Console.WriteLine("Enter the updated quantity of the inventory:");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    dictlist[name] = quantity;
                    Console.WriteLine($"Updated {name}: New quantity = {quantity}");
                }
                else
                {
                    Console.WriteLine("Invalid quantity input.");
                }
            }
            else
            {
                Console.WriteLine("The inventory doesn't exist.");
            }
        }

        
        public void markDefective()
        {
            Console.WriteLine("Enter the name of the product to mark as defective:");
            string name = Console.ReadLine();

            if (dictlist.ContainsKey(name))
            {
                defectiveProducts.Add(name);
                dictlist.Remove(name); 
                Console.WriteLine($"{name} is marked as defective and removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{name} does not exist in inventory.");
            }
        }

        public void showallsoftware()
        {
            if (dictlist.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            foreach (var item in dictlist)
            {
                Console.WriteLine($"Name: {item.Key}, Quantity: {item.Value}");
            }
        }
    }
}
