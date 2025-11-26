using ECommerce;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        ElectronicProduct laptop = new ElectronicProduct(101,24, "Laptop", 50000m);
        GroceryProduct milk = new GroceryProduct(201, DateTime.Today.AddDays(4), "Milk", 45.50m);
        GroceryProduct bread = new GroceryProduct(202, DateTime.Today.AddDays(3), "Bread", 40m );

        ShoppingCart cart = new ShoppingCart(5);

        cart.AddProudct(laptop);
        cart.AddProudct(milk);
        cart.AddProudct(bread);

        cart.DisplayCartContents();

        cart.RemoveProduct(200);

        cart.DisplayCartContents();







    }
}