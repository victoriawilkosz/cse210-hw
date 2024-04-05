using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating customers
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Los Angeles", "CA", "USA");
        Customer customer2 = new Customer("Jane Smith", address2);

        Address address3 = new Address("23 New St", "Salt Lake City", "UT", "USA");
        Customer customer3 = new Customer("Oliver Peterson", address3);

        Address address4 = new Address("Kokoryczki 6", "Warszawa", "Mazowieckie", "Poland");
        Customer customer4 = new Customer("Wiktoria Wilkosz", address4);

        // Creating products
        Product product1 = new Product("Product 1", "P001", 10.00, 1);
        Product product2 = new Product("Product 2", "P002", 20.00, 1);
        Product product3 = new Product("Product 3", "P003", 30.00, 1);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product2);

        Order order4 = new Order(customer4);
        order4.AddProduct(product3);
        order4.AddProduct(product2);
        order4.AddProduct(product1);

        // Displaying order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");

        Console.WriteLine("\nOrder 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order3.GetTotalPrice()}");

        Console.WriteLine("\nOrder 4:");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order4.GetTotalPrice()}");
    }
}