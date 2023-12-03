using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //addresses
        Address usaAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Address nonUsaAddress = new Address("456 Maple Ave", "Townsville", "ON", "Canada");

        //customers
        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer nonUsaCustomer = new Customer("Jane Smith", nonUsaAddress);

        //products
        Product laptop = new Product("Laptop", 1, 999.99m, 2);
        Product smartphone = new Product("Smartphone", 2, 299.99m, 3);

        //orders
        Order usaOrder = new Order(usaCustomer, new List<Product> { laptop, smartphone });
        Order nonUsaOrder = new Order(nonUsaCustomer, new List<Product> { smartphone });


        Console.WriteLine("USA Order:");
        Console.WriteLine(usaOrder.GetPackingLabel());
        Console.WriteLine(usaOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${usaOrder.CalculateTotalCost():F2}\n");

        Console.WriteLine("Non-USA Order:");
        Console.WriteLine(nonUsaOrder.GetPackingLabel());
        Console.WriteLine(nonUsaOrder.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${nonUsaOrder.CalculateTotalCost():F2}");
    }
}