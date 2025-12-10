using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        SortedList inventory = new SortedList();

        inventory.Add(101, "Milk");
        inventory.Add(102, "Bread");
        inventory.Add(103, "Eggs");
        inventory.Add(104, "Butter");
        inventory.Add(105, "Cheese");

        Console.WriteLine("Initial inventory:");
        DisplayInventory(inventory);

        inventory.Remove(103);
        Console.WriteLine("\n After removing Butter (product ID 103):");
        DisplayInventory(inventory);

        int searchKey = 105;
        Console.WriteLine($"\n Contains Key {searchKey}? {inventory.ContainsKey(searchKey)}");

        int keytoFind = 102;
        int indexKey = inventory.IndexOfKey(keytoFind);
        Console.WriteLine($"\n Index of Product ID {keytoFind}: {indexKey}");
        Console.ReadLine();

        string valueToFind = "Cheese";
        int indexValue = inventory.IndexOfValue(valueToFind);
        Console.WriteLine($"\n Index of Product '{valueToFind}' : {indexValue}");
        Console.ReadLine();

        Console.WriteLine($"\n Total products in Inventory : {inventory.Count}");
        Console.ReadLine();
    }

    static void DisplayInventory(SortedList inventory)
    {
        foreach(DictionaryEntry item in  inventory)
        {
            Console.WriteLine($"Product ID: {item.Key}, Product Name: {item.Value}");
        }
        Console.ReadLine();
    }
}