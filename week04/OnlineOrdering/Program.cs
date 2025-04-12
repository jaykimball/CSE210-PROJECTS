using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.\n");

        // First order
        Address address1 = new Address("123 River Rd", "Dallas", "TX", "USA");
        Customer customer1 = new Customer("John Momoh", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Raft Paddle", "RP001", 25.99, 2));
        order1.AddProduct(new Product("Life Jacket", "LJ002", 45.50, 1));

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Second order
        Address address2 = new Address("78 Ocean Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maya Kim", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Dry Bag", "DB003", 15.75, 3));
        order2.AddProduct(new Product("Helmet", "HM004", 30.00, 1));

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
