using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public double ProductTotalCost()
    {
        return _pricePerUnit * _quantity;
    }
}