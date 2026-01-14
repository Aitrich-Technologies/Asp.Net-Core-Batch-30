using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
       SortedList inventory = new SortedList();

        inventory.Add(101, "Milk");
        inventory.Add(105, "Bread");
        inventory.Add(102, "Eggs");
        inventory.Add(103, "Butter");
        inventory.Add(104, "Cheese");

        Console.WriteLine("Initial Inventory:");
        DisplayInventory(inventory);

        inventory.Remove(103);
        Console.WriteLine("\nAfter removing Butter (Product ID 103):");
        DisplayInventory(inventory);


        int searchKey = 105;
        Console.WriteLine($"\nContains Key {searchKey}? {inventory.ContainsKey(searchKey)}");

        int keyToFind = 102;
        int indexKey = inventory.IndexOfKey(keyToFind);
        Console.WriteLine($"\nIndex of Product ID {keyToFind}: {indexKey}");
        Console.ReadLine();


        string valueToFind = "Cheese";
        int indexValue = inventory.IndexOfValue(valueToFind);
        Console.WriteLine($"\nIndex of Product '{valueToFind}': {indexValue}");
        Console.ReadLine();

        Console.WriteLine($"\nTotal Products in Inventory: {inventory.Count}");
        Console.ReadLine();
    }
    static void DisplayInventory(SortedList inventory)
    {
        foreach (DictionaryEntry item in inventory)
        {
            Console.WriteLine($"Product ID: {item.Key}, Product Name: {item.Value}");
        }
        Console.ReadLine();
    }
}