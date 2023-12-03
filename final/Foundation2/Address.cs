using System;
using System.Collections.Generic;

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    // Constructor for Address
    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Method to return a formatted string of all address fields
    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}