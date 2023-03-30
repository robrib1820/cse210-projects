using System;

class Program
{
    static void Main(string[] args)
    {
        List<Event> _listOfEvents = new List<Event>();
        Lectures event1 = new Lectures("Robson Ribeiro", 200, "imagine dragons show",
        "The band's new album tour is about to start soon in various places around the world!",
        "04/04/2023","14:00", "Av. Francisco Matarazzo, 1705 - Água Branca, São Paulo - SP", "Lectures",
        "Without Specific Information yet!");
        Receptions event2 = new Receptions("Yes", "Robson and karlyn Wedding","A special night to celebrate this eternal bond.",
        "26/11/2021", "20:00","R. Me. Henriqueta Dominici, 750 - Lagoa Dourada",
        "Receptions","Don't forget to take a picture with the bride and groom!");
        OutdoorGatherings event3 = new OutdoorGatherings("The day will be sunny with few clouds", "Expo Londrina",
        "It is the exhibition of rural products with artistic attractions and lots of fun in the city of Londrina.",
        "06/04/2023", "08:00", "Av. Tiradentes, 6275 - Jardim Rosicler, Londrina - PR","Outdoor Gatherings",
        "You can pay a fixed amount and use all the rides in the park");
        // OutdoorGatherings event3 = new OutdoorGatherings();
        _listOfEvents.Add(event1);
        _listOfEvents.Add(event2);
        _listOfEvents.Add(event3);

        foreach(Event evnt in _listOfEvents)
        {
            if (evnt.GetEventType() =="Lectures")
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("================================================================");
                evnt.StandardDetailsMessage();
                Console.WriteLine("================================================================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("================================================================");
                event1.LecturesFullDetails();
                Console.WriteLine("================================================================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("================================================================");
                evnt.ShortDescriptionMessage();

            } else if (evnt.GetEventType() == "Receptions")
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("================================================================");
                evnt.StandardDetailsMessage();
                Console.WriteLine("================================================================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("================================================================");
                event2.ReceptionsFullDetails();
                Console.WriteLine("================================================================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("================================================================");
                evnt.ShortDescriptionMessage();
            } else if (evnt.GetEventType() == "Outdoor Gatherings")
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("Standard Details Message");
                Console.WriteLine("================================================================");
                evnt.StandardDetailsMessage();
                Console.WriteLine("================================================================");
                Console.WriteLine("Full Details Message");
                Console.WriteLine("================================================================");
                event3.OutdoorFullDetails();
                Console.WriteLine("================================================================");
                Console.WriteLine("Short Description Message");
                Console.WriteLine("================================================================");
                evnt.ShortDescriptionMessage();
            }
        }

        
    }
}