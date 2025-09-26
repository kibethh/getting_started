using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        /*
         * Create a List<> of strings and initalise the list with items
         * Ask user to input a new item
            * Use add function to insert the item into the list
            * Print the new list and clear the console after a readline
         * Ask a user to enter an item they want to update
            * Iterate and find the index of the item
            * If found, ask user to enter the replacement
            * If not found, output "Update item not found"
            * Print the new list and clear the console after a readline
         * Ask a user to enter an item they want to delete
            * Iterate and find the index of the item
            * If found, remove the element at that index
            * If not found, output "Delete item not found"
            * Print new list
        */
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk", "Eggs"
            };//0

            Console.Write("Enter a new item: ");
            string input = Console.ReadLine();

            bool found = false;

            /*for (int i = 0; i < shoppingList.Count; i++)
            {
                if (shoppingList[i].ToLower().Equals(input.ToLower()))
                {
                    found = true;
                }
            }
            //
            if (found) //$"{input} is already in the list.\n"
                       //else shoppingList.Add(input);*/

            if (!shoppingList.Contains(input))
            {
                shoppingList.Add(input);
            }
            else
            {
                Console.WriteLine($"{input} is already in the list.\n");
            }

            /*for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }*/

            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            //End of section 1 (Add)

            Console.Write("Enter a item you want to update: ");
            string update = Console.ReadLine();
            int index = shoppingList.IndexOf(update);

            if (index > -1)
            {
                Console.Write("Enter your replacement: ");
                update = Console.ReadLine();
                shoppingList[index] = update;
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            Console.Clear();

            //End of section 2 (Update)

            Console.Write("Enter an item you want to delete: ");
            string delete = Console.ReadLine(); //Coffee

            if (shoppingList.Remove(delete))
            {
                Console.WriteLine($"Found and removed item {delete}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }

            /*index = shoppingList.IndexOf(delete);

            if (index > -1)
            {
                shoppingList.RemoveAt(index);

                Console.WriteLine($"Found and removed item {delete}");
            }
            else
            {
                Console.WriteLine("Item not found.");
            }*/

            foreach (var item in shoppingList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
