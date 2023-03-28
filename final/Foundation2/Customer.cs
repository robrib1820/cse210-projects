using System;

public class Customer
{
    private string _personName;
    private Address _address = new Address();

    public Customer() {

    }
    public void UsaCountry() {
        _address.IsUsa();
    }
}