using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float GetTotalCost()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total = total + product.GetTotalCost();
        }

        float shippingPrice = 0;
        if (_customer.IsInUsa())
        {
            shippingPrice = shippingPrice + 5;
        }
        else
        {
            shippingPrice = shippingPrice + 35;
        }

        return total + shippingPrice;
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += product.GetProductLabel() + "\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetCustomerLabel();
    }
}