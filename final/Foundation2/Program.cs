using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1 West Carriage Hill Drive", "Poquoson", "VA","USA");
        Customer customer1 = new Customer("Benjamin White", address1);
        Order order1 = new Order(customer1);

        order1.ShippingLabel();
    }
}  