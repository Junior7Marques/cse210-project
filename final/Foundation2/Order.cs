using System;
using System.Collections.Generic;

class Order
{
    private List<Product> Products { get; set; }
    public Customer Customer { get; set; }


    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }


    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        totalCost += Customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    //get the packing label for the order
    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    //get the shipping label for the order
    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {Customer.Name}\n";
        shippingLabel += $"Address: {Customer.CustomerAddress.GetFullAddress()}";

        return shippingLabel;
    }
}