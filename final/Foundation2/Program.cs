using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1 West Carriage Hill Drive", "Poquoson", "VA","USA");
        Customer customer1 = new Customer("Benjamin White", address1);
        Order order1 = new Order(customer1);
        order1.AddProductToList(new Product("Kids Camera", "KC1234", 18.99, 1));
        order1.AddProductToList(new Product("Fiber Gummies", "FG5678", 5.99, 1));
        order1.AddProductToList(new Product("Scratch Notes", "SN6789", 8.99, 3));

        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order1.TotalCost():F2}");
        
        Console.WriteLine("\n--------------------------------\n");

        Address address2 = new Address("615 Calle Independencia", "Obregon", "Son", "Mexico");
        Customer customer2 = new Customer("Esther Medina", address2);
        Order order2 = new Order(customer2);
        order2.AddProductToList(new Product("Chair Covers", "CC0123", 18.60, 2));
        order2.AddProductToList(new Product("Pregnancy Pillow", "PP3456", 29.99, 1));

        order2.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order2.TotalCost():F2}");   
    }
}  