using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private Customer _customer;
    private List<Product> _productList;

    public Order(Customer customer)
    {
        _customer = customer;
        _productList = new List<Product>();
    }

    public double TotalCost() // total price = sum of total cost of each product plus one time shipping cost
// if in USA shipping cost is $5. if not in the USA shipping cost is $35
    {
        double total = 0;
        foreach (var product in _productList)
        {
            total += product.ProductTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;

    }

    public string PackingLabel() // packing label -  list name and product id of each product in order   ** works
    {
        string label="";
        Console.WriteLine("Order: ");
        foreach (var product in _productList)
        {
            label += product.ProductInfo() + "\n";
        }
        return label;
    }

    public void ShippingLabel() // shipping label. list name and address of the customer  *** works
    {
        Console.WriteLine($"Shipping to:\n{_customer.NameAndAddress()}");
    }
 
    public void AddProductToList(Product product)
    {
        _productList.Add(product);
    }
}


