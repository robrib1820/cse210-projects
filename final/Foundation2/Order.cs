using System;
public class Order
{
    private List<Product> _listOfProducts = new List<Product>();
    private List<Customer> _listOfCustomers = new List<Customer>();
    private List<Address> _listOfAddress = new List<Address>();
    private string _customer;
    private float _totalCost;
    private int _shippingCost;
    private string _country;
    public Order() {

    }
    public void CalculateTotalCost() {
        Address address = new Address();
        if (address.GetIfIsUsa() == "USA")
        {
            SetShippingCost(5);
        } else 
        {
            SetShippingCost(35);
        }
        float total = 0;
        foreach (Product product in _listOfProducts) 
        {
            float value = (product.GetPrice());
            total+= value;
        }
        Console.WriteLine($"The total cost of this order is: {total + _shippingCost}");
    }
    public void AddToList(Product product) {
        _listOfProducts.Add(product);
    }
    public void AddtoListCustomer(Customer customer) {
        _listOfCustomers.Add(customer);
    }
    public void AddtoListAddress(Address address) {
        _listOfAddress.Add(address);
    }
    public string GetCustomer() {
        return _customer;
    }
    public void SetCustomer(string customer) {
        _customer = customer;
    }
    public int GetShippingCost() {
        return _shippingCost;
    }
    public void SetShippingCost(int shipping) {
        _shippingCost = shipping;
    }
    public void PackingLabel() {
        foreach (Product product in _listOfProducts)
        {
            Console.WriteLine($"Product: {product.GetName()}..........ID: {product.GetProdID()}");
        }
        Console.WriteLine();
    }
    public void ShippingLabel() {
        Console.WriteLine("Name and Address: ");
        Console.WriteLine();
        foreach (Customer customer in _listOfCustomers)
        {
            Console.WriteLine($"Name: {customer.GetPersonName()}");
        }
        foreach (Address address in _listOfAddress)
        {
            Console.WriteLine(address.AddressInformation());
        }
    }
}