using System;

class Program
{
    static void Main(string[] args)
    {
        //order1
        Order order1 = new Order();
        Product product1 = new Product();
        product1.SetName("shoe");
        product1.SetProdID("001");
        product1.SetPrice(70);
        product1.SetQuantityOfProd(2);
        order1.AddToList(product1);

        Product product2 = new Product();
        product2.SetName("pants");
        product2.SetProdID("013");
        product2.SetPrice(100);
        product2.SetQuantityOfProd(3);
        order1.AddToList(product2);

        Product product3 = new Product();
        product3.SetName("backpack");
        product3.SetProdID("25");
        product3.SetPrice(160);
        product3.SetQuantityOfProd(1);
        order1.AddToList(product3);

        order1.SetCustomer("Robson Ribeiro");
        order1.CalculateTotalCost();


        //order2
        Product product4 = new Product();
        product1.SetName("television");
        product1.SetProdID("243");
        product1.SetPrice(1160);
        product1.SetQuantityOfProd(1);
        Product product5 = new Product();
        product1.SetName("abajur");
        product1.SetProdID("104");
        product1.SetPrice(20);
        product1.SetQuantityOfProd(2);
        Product product6 = new Product();
        product1.SetName("table lack");
        product1.SetProdID("89");
        product1.SetPrice(87);
        product1.SetQuantityOfProd(1);
        
    }
}