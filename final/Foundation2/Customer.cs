using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA() // customer lives in the usa? **this should call a method on the address to find this**
    {
        return _address.IsInUSA();
    }

    public string NameAndAddress()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }
}