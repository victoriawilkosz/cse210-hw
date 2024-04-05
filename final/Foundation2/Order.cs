using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private double shippingCost = 0;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
        if (!customer.IsInUSA())
            shippingCost = 35;
        else
            shippingCost = 5;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.GetTotalCost();
        }
        return totalPrice + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.Name} - {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName: {customer.Name}\nAddress: {customer.Address.GetFullAddress()}";
    }
}