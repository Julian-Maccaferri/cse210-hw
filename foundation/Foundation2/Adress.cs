using System;
using System.Collections.Generic;
public class Adress
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Adress (string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUsa()
    {
        if (_country.ToUpper() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAdress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";    
    }
}