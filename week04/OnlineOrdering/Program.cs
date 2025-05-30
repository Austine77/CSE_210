// Program.cs
class Program
{
    static void Main()
    {
        Address addr1 = new("456 Main St", "Salt Lake", "UT", "USA");
        Customer cust1 = new("Sunday Prince", addr1);

        Order order1 = new(cust1);
        order1.AddProduct(new Product("USB Cable", "A123", 5.99, 2));
        order1.AddProduct(new Product("Keyboard", "K456", 25.00, 1));

        Console.WriteLine("Order 1 Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Address addr2 = new("456 Pine Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new("Alice Johnson", addr2);

        Order order2 = new(cust2);
        order2.AddProduct(new Product("Mouse", "M789", 15.50, 1));
        order2.AddProduct(new Product("Monitor", "MN012", 200.00, 1));

        Console.WriteLine("Order 2 Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}
