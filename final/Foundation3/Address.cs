using System;

public class Address
{
    private string _address;

    public Address(string address) {
        _address = address;
    }
    public void DisplayAddress() {
        Console.WriteLine($"Address: {_address}");
    }
}