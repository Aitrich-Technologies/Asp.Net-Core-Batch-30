using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        ArrayList trackingNumbers = new ArrayList();

        Hashtable shipmentDetails = new Hashtable();

       
        SortedList sortedShipments = new SortedList();

        
        Queue shipmentQueue = new Queue();

        
        Stack undoStack = new Stack();

       
        string tracking1 = "SHIP001";
        string tracking2 = "SHIP002";
        string tracking3 = "SHIP003";

        trackingNumbers.Add(tracking1);
        trackingNumbers.Add(tracking2);
        trackingNumbers.Add(tracking3);

        shipmentDetails[tracking1] = "Sender: Alice, Receiver: Bob, Status: In Transit";
        shipmentDetails[tracking2] = "Sender: Charlie, Receiver: David, Status: Delivered";
        shipmentDetails[tracking3] = "Sender: Eve, Receiver: Frank, Status: Pending";

        sortedShipments.Add(DateTime.Parse("2025-02-10"), tracking1);
        sortedShipments.Add(DateTime.Parse("2025-02-08"), tracking2);
        sortedShipments.Add(DateTime.Parse("2025-02-12"), tracking3);

        shipmentQueue.Enqueue(tracking1);
        shipmentQueue.Enqueue(tracking2);
        shipmentQueue.Enqueue(tracking3);

        undoStack.Push("Modified shipment details for " + tracking2);
        undoStack.Push("Cancelled shipment " + tracking3);

        
        Console.WriteLine("Tracking Numbers in System:");
        foreach (string track in trackingNumbers)
        {
            Console.WriteLine(track);
        }

        
        Console.WriteLine("\nShipment Details for SHIP002:");
        Console.WriteLine(shipmentDetails[tracking2]);

        
        Console.WriteLine("\nShipments sorted by estimated delivery date:");
        foreach (DictionaryEntry entry in sortedShipments)
        {
            Console.WriteLine($"Delivery Date: {entry.Key}, Tracking Number: {entry.Value}");
        }

      
        Console.WriteLine("\nProcessing Shipments (FIFO Order):");
        while (shipmentQueue.Count > 0)
        {
            Console.WriteLine("Processing Shipment: " + shipmentQueue.Dequeue());
        }

    
        Console.WriteLine("\nUndo Last Actions (LIFO Order):");
        while (undoStack.Count > 0)
        {
            Console.WriteLine("Undo: " + undoStack.Pop());
        }
    }
}