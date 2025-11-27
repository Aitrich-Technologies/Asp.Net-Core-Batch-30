using E_Commerce_System;

internal class Program
{
    private static void Main(string[] args)
    {
        Product[] products = new Product[4];

        products[0] = new Electronics(101, "Laptop", 10000);
        products[1] = new Clothing(102, "Shirt", 1000);
        products[2] = new Electronics(103, "Mobile Phone", 20000);
        products[3] = new Clothing(104, "T-Shirt", 1000);



        foreach (Product p in products)
        {



            double discount = p.CalculateDiscount(p.Price);

            double finalAmount = p.Price - discount;


            Console.WriteLine($"Product: {p.ProductName} Price: {p.Price}  Discount: {discount} FinalAmount:{finalAmount}");
        }

    }
}