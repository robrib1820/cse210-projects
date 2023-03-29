using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _value;

    public Address() {

    }
    public Address(string value) {
        _value = value;
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
    public string GetIfIsUsa() {
        return _value;
    }
    // public void SetIfIsUsa(string value) {
    //     _value = value;
    // }
    public string AddressInformation() {
        return ($"Country: {_country}, State: {_state}, City: {_city}, Street: {_streetAddress}");
    }
}