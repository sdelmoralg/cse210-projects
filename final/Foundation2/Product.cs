using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string productName, string productId, double pricePerUnit, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double ProductTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}