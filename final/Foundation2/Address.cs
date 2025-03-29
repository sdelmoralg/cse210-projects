using System;
using System.Net.WebSockets;

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

    public bool IsInUSA() // is in the usa?
    {
		if (_country != "usa")
        {
            return false;
        }
        else
        {
			return true;
        }    
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}. {_country}";
    }
}	