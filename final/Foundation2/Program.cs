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

        order1.ShippingLabel();
        Console.WriteLine();
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Total Price:");
        Console.WriteLine($"${order1.TotalCost():F2}");
    }
}  