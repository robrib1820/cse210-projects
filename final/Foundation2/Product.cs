using System;
public class Product
{
    private string _name;
    private string _prodID;
    private float _price;
    private int _quantityOfProd;

    public Product() {

    }
    public Product(string prodID, string name, float price, int quantityOfProd) {
        _prodID = prodID;
        _name = name;
        _price = price;
        _quantityOfProd = quantityOfProd;
    }
    // public void TotalProductPrice() {
    //     change for int
    // }
    public string GetName() {
        return _name;
    }
    public void SetName(string name) {
        _name = name;
    }
    public string GetProdID() {
        return _prodID;
    }
    public void SetProdID(string prodID) {
        _prodID = prodID;
    }
    public float GetPrice() {
        return _price;
    }
    public void SetPrice(float price ) {
        _price = price;
    }
    public int GetQuantityOfProd() {
        return _quantityOfProd;
    }
    public void SetQuantityOfProd(int quantityOfProd) {
        _quantityOfProd = quantityOfProd;
    }
    public float PriceOfProduct() {
        return _price * _quantityOfProd;
    }
}