using System;
public class Order
{
    private List<Product> _listOfProducts = new List<Product>();
    private string _customer;
    private float _totalCost;
    private int _shippingCost;
    private string _country;
    // _shippingLabel  - need to be a method
    // _packingLabel   - need to be a method

    public Order() {

    }
    public void CalculateTotalCost() {
        float total = 0;
        foreach (Product product in _listOfProducts) 
        {
            float value = (product.GetPrice());
            total+= value;
        }
        Console.WriteLine(total);
    }
    public void AddToList(Product product) {
        _listOfProducts.Add(product);
    }
    public string GetCustomer() {
        return _customer;
    }
    public void SetCustomer(string customer) {
        _customer = customer;
    }
    // public string PackingLabel() {
        //return a string
    // }
    // public string ShippingLabel() {
        //return a string
    // }
}