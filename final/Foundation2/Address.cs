using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address() {

    }
    public Boolean IsUsa() {
        return true;
    }
    public string AddressInformation() {
        return _country + " " + _state + " " + _city + " " + _streetAddress;
    }
}