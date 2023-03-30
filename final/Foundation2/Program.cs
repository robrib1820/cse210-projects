using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> _listOrder = new List<Order>();
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

        //order2
        Order order2 = new Order();
        Address address2 = new Address("USA");
        Customer customer2 = new Customer();
        Product product4 = new Product();
        product4.SetName("television");
        product4.SetProdID("243");
        product4.SetPrice(1160);
        product4.SetQuantityOfProd(1);
        order2.AddToList(product4);
        Product product5 = new Product();
        product5.SetName("abajur");
        product5.SetProdID("104");
        product5.SetPrice(20);
        product5.SetQuantityOfProd(2);
        order2.AddToList(product5);
        Product product6 = new Product();
        product6.SetName("table lack");
        product6.SetProdID("89");
        product6.SetPrice(87);
        product6.SetQuantityOfProd(1);
        order2.AddToList(product6);

        customer2.SetPersonName("Karlin Eliza Castro");
        address2.SetCity("Salt Lake City");
        address2.SetState("Utah");
        address2.SetCountry("Usa");
        address2.SetStreetAddress("278 E 1300 S");

        order2.AddtoListCustomer(customer2);
        order2.AddtoListAddress(address2);

        _listOrder.Add(order1);
        _listOrder.Add(order2);
        
        foreach(Order order in _listOrder)
        {
            Console.WriteLine("============================================================================================");
            order.PackingLabel();
            order.ShippingLabel();
            order.CalculateTotalCost();
            Console.WriteLine("============================================================================================");
        }
    }
}