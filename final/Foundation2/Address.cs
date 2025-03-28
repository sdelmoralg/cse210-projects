using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return // is in the usa?
    }

    public void GetAddress()
    {
        Console.WriteLine($"{_street}, {_city},\n{_state} {_country}");
    }
}