using Activity;

internal class Program
{
    private static void Main(string[] args)
    {
        ElectronicProduct ep = new ElectronicProduct(100, "Mobile", 25000, 4, 6, "Samsung");
        ClothingProduct cp = new ClothingProduct(200, "T-Shirt", 500, 10, 40, "Linen");

        Orders od = new Orders(300, "Vishnu", DateOnly.FromDateTime(DateTime.Now));
        od.p[0]= ep;
        od.p[1]= cp;

        od.DisplayDetails();
    }
}