using System;
using System.Collections.Generic;
public class Customer
{
    private string _name;

    private Adress _adress;

    public Customer (string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public bool IsInUsa()
    {
        return _adress.IsInUsa();
    }

    public string GetCustomerLabel()
    {
        return $"{_name}\n{_adress.GetAdress()}";
    } 
}
