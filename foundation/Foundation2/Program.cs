using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Adress adress1 = new Adress("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Mookie Betts", adress1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wooden Bat", "WOB123", 999, 1));
        order1.AddProduct(new Product("Helmet", "HEL456", 25, 2));
        order1.AddProduct(new Product("Glove", "GLO789", 49, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost() + "\n");

        Adress adress2 = new Adress("Richieri 1070", "Rosario", "SF", "Argentina");
        Customer customer2 = new Customer("Julian Maccaferri", adress2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Smartphone", "SMP101", 699, 1));
        order2.AddProduct(new Product("Charger", "CHG202", 19, 1));
        order2.AddProduct(new Product("Head Phone", "ERB303", 49, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}