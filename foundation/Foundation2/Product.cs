using System;
using System.Collections.Generic;
public class Product
{
    private string _name;
    private string _productId;
    private float _unitPrice;
    private int _quantity;

    public Product (string name, string productId, float unitPrice, int quantity)
    {
        _name = name;
        _productId = productId;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public float GetTotalCost()
    {
        return _unitPrice * _quantity;
    }

    public string GetProductLabel()
    {
        return $"{_name}, ID: {_productId}";
    }
}