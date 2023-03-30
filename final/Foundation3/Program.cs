using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _listOfEvents = new List<Event>();
        Lectures event1 = new Lectures("Robson Ribeiro", 200, "imagine dragons show",
        "The band's new album tour is about to start soon in various places around the world!",
        "04/04/2023","14:00", "Lectures",
        "Without Specific Information yet!");
        Address address1 = new Address("Av. Francisco Matarazzo, 1705 - Água Branca, São Paulo - SP");
        Receptions event2 = new Receptions("Yes", "Robson and karlyn Wedding","A special night to celebrate this eternal bond.",
        "26/11/2021", "20:00",
        "Receptions","Don't forget to take a picture with the bride and groom!");
        Address address2 = new Address("R. Me. Henriqueta Dominici, 330 - Lagoa Dourada");
        OutdoorGatherings event3 = new OutdoorGatherings("The day will be sunny with a few clouds", "Expo Londrina",
        "It is the exhibition of rural products with artistic attractions and lots of fun in the city of Londrina.",
        "06/04/2023", "08:00","Outdoor Gatherings",
        "You can pay a fixed amount and use all the rides in the park");
        Address address3 = new Address("Av. Tiradentes, 6275 - Jardim Rosicler, Londrina - PR");
        _listOfEvents.Add(event1);
        _listOfEvents.Add(event2);
        _listOfEvents.Add(event3);

        foreach(Event evnt in _listOfEvents)
        {
            if (evnt.GetEventType() =="Lectures")
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("===========================");
                evnt.StandardDetailsMessage();
                address1.DisplayAddress();
                Console.WriteLine("=======================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("=======================");
                event1.LecturesFullDetails();
                address1.DisplayAddress();
                Console.WriteLine("============================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("============================");
                evnt.ShortDescriptionMessage();
                Console.WriteLine("/---------------------------------------------------------------------------/");

            } else if (evnt.GetEventType() == "Receptions")
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("===========================");
                evnt.StandardDetailsMessage();
                address2.DisplayAddress();
                Console.WriteLine("=======================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("=======================");
                event2.ReceptionsFullDetails();
                address2.DisplayAddress();
                Console.WriteLine("===========================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("===========================");
                evnt.ShortDescriptionMessage();
                Console.WriteLine("/---------------------------------------------------------------------------/");
            } else if (evnt.GetEventType() == "Outdoor Gatherings")
            {
                Console.WriteLine("==========================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("==========================");
                evnt.StandardDetailsMessage();
                address3.DisplayAddress();
                Console.WriteLine("======================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("======================");
                event3.OutdoorFullDetails();
                address3.DisplayAddress();
                Console.WriteLine("===========================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("===========================");
                evnt.ShortDescriptionMessage();
            }
        }

        
    }
}