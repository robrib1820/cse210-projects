using System;

public class Customer
{
    private string _personName;
    private List<Address> _address = new List<Address>();

    public Customer() {

    }
    // public void UsaCountry() {
    //     _address.IsUsa();
    // }
    public string GetPersonName() {
        return _personName;
    }
    public void SetPersonName(string name) {
        _personName = name;
    }
    public void Address() {
        foreach (Address address in _address)
        {
            Console.WriteLine(address.GetStreetAddress());
        }
    }
}