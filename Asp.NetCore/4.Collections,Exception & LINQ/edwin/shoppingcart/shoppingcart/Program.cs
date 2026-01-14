using shoppingcart;
using static shoppingcart.Shopingcart;

internal class Program
{
    private static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();

        while (true)
        {
            try
            {
                Console.WriteLine("\n===== SHOPPING CART MENU =====");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Calculate Total");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter item name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter item price: ");
                        double price = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        cart.AddItem(new Items(name, price, quantity));
                        break;

                    case "2":
                        Console.Write("Enter item name to remove: ");
                        string removeName = Console.ReadLine();
                        cart.RemoveItem(removeName);
                        break;

                    case "3":
                        Console.Write("Enter discount percentage: ");
                        double discount = Convert.ToDouble(Console.ReadLine());

                        double totalAfterDiscount = cart.ApplyDiscount(discount);
                        Console.WriteLine($"Total After Discount: {totalAfterDiscount}");
                        break;

                    case "4":
                        Console.WriteLine($"Total Price: {cart.CalculateTotal()}");
                        break;

                    case "5":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option! Try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
