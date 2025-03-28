using System;
using System.ComponentModel;

public class Order
{
    private Customer _customer;
    private List<Product> _productList = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public double TotalCost()
    {
        return // total cost
    }

    public string PackingLabel()
    {
        return // packing label. list name and product id of each product in order
    }

    public string ShippingLabel()
    {
        return // shipping label. list name and address of the customer
    }
}

// total price = sum of total cost of each product plus one time shipping cost
// if in USA shipping cost is $5. if not in the USA shipping cost is $35
