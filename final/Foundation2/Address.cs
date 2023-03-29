using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address() {

    }
    public string GetStreetAddress() {
        return _streetAddress;
    }
    public void SetStreetAddress(string address) {
        _streetAddress = address;
    }
    public string GetCity() {
        return _city;
    }
    public void SetCity(string city) {
        _city = city;
    }
    public string GetState() {
        return _state;
    }
    public void SetState(string state) {
        _state = state;
    }
    public string GetCountry() {
        return _country;
    }
    public void SetCountry(string country) {
        _country = country;
    }
    public void IsUsa() {
        Order shippingCost = new Order();
        if (_country == "USA")
        {
            shippingCost.SetShippingCost(5);
        } else
        {
            shippingCost.SetShippingCost(35);
        }
    }
    public string AddressInformation() {
        return ($"Country: {_country}, State: {_state}, City: {_city}, Street: {_streetAddress}");
    }
}