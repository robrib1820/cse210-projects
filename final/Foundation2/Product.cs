using System;
public class Product
{
    private string _name;
    private string _prodID;
    private int _price;
    private int _quantityOfProd;

    public Product() {

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
    public int GetPrice() {
        return _price;
    }
    public void SetPrice(int price ) {
        _price = price;
    }
    public int GetQuantityOfProd() {
        return _quantityOfProd;
    }
    public void SetQuantityOfProd(int quantityOfProd) {
        _quantityOfProd = quantityOfProd;
    }
}