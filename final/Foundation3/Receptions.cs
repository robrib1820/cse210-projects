using System;

public class Receptions : Event
{
    private string _rsvp;

    public Receptions(string eventTitle, string description, string data, string time, string address, string eventType, string specificInformation) : base(eventTitle, description, data, time, address, eventType, specificInformation) {

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
    public string ReceptionsFullDetails() {
        return "something";
    }

    public string ReceptionsShortDescription() {
        return "something";
    }
    
}