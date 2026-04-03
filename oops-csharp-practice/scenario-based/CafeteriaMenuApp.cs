using System;

class CafeteriaMenuApp
{
    static void Main()
    {
        // Array of 10 fixed items
        string[] menuItems = {
            "Veg Sandwich",
            "Cheese Pizza",
            "Pasta",
            "Masala Dosa",
            "Fried Rice",
            "Manchurian",
            "Cold Coffee",
            "Tea",
            "French Fries",
            "Chocolate Shake"
        };

        // Display menu
        DisplayMenu(menuItems);

        Console.WriteLine("\nEnter the item number you want to order:");
        int index = int.Parse(Console.ReadLine());

        // Get selected item
        string selectedItem = GetItemByIndex(menuItems, index);

        Console.WriteLine($"\nYou selected: {selectedItem}");
    }


    // Method 1: Display the menu
    static void DisplayMenu(string[] items)
    {
        Console.WriteLine("=== Cafeteria Menu ===");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i}. {items[i]}");
        }
    }

    // Method 2: Get item by index
    static string GetItemByIndex(string[] items, int index)
    {
        if (index < 0 || index >= items.Length)
        {
            return "Invalid Choice!";
        }
        return items[index];
    }
}
