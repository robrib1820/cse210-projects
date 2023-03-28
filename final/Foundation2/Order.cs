using System;
public class Order
{
    private List<string> _listOfProducts = new List<string>();
    private string _customer;
    private float _totalCost;
    private int _shippingCost;
    private string _country;
    // _shippingLabel  - need to be a method
    // _packingLabel   - need to be a method

    public Order() {

    }
    public float CalculateTotalCost() {
        return _totalCost;
    }
    // public string PackingLabel() {
        //return a string
    // }
    // public string ShippingLabel() {
        //return a string
    // }
}