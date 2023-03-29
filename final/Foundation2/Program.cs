using System;

class Program
{
    static void Main(string[] args)
    {
        //order1
        Order order1 = new Order();
        Product product1 = new Product();
        Address address1 = new Address("USA");
        Customer customer1 = new Customer();
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

        customer1.SetPersonName("Robson Ribeiro");
        address1.SetCity("Londrina");
        address1.SetState("Paraná");
        address1.SetCountry("Brasil");
        address1.SetStreetAddress("Rua Madre Henriqueta Dominici, 750");
        // address1.SetIfIsUsa("Yes");
        order1.AddtoListCustomer(customer1);
        order1.AddtoListAddress(address1);

        Console.WriteLine("============================================================================================");
        order1.CalculateTotalCost();
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine("============================================================================================");


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