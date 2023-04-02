using System;

public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string rsvp, string eventTitle, string description, string data, string time, string eventType, string specificInformation) : base(eventTitle, description, data, time, eventType, specificInformation) {
        _rsvp = rsvp;
    }
    public string GetRsvp() {
        return _rsvp;
    }
    public void SetRsvp(string rsvp) {
        _rsvp = rsvp;
    }
    public string RecptionsStandardDetails() {
        return "something";
    }
    public void ReceptionsFullDetails() {
        StandardDetailsMessage();
        if (_rsvp == "Yes")
        {
            Console.WriteLine("Will attend [x]");
        } else 
        {
            Console.WriteLine("Will not attend []");
        }
    }

    public string ReceptionsShortDescription() {
        return "something";
    }
    
}