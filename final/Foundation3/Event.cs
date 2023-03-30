using System;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _data;
    private string _time;
    // private string _address;
    private string _eventType;
    private string _specificInformation;

    public Event(string eventTitle, string description, string data, string time, string eventType, string specificInformation) {
        _eventTitle = eventTitle;
        _description = description;
        _data = data;
        _time = time;
        // _address = address;
        _eventType = eventType;
        _specificInformation = specificInformation;
    }
    public string GetEventTitle() {
        return _eventTitle;
    }
    public string GetDescription() {
        return _description;
    }
    public string GetData() {
        return _data;
    }
    public string GetTime() {
    return _time;
    }
    // public string GetAddress() {
    //     return _address;
    // }
    public string GetEventType() {
        return _eventType;
    }
    public string GetSpecificInformation() {
        return _specificInformation;
    }
    public void StandardDetailsMessage() {
        Console.WriteLine($"Title: {_eventTitle}, Description: {_description}");
        Console.WriteLine($"Date: {_data}, Time: {_time}");
    }
    public string FullDetailsMessage() {
        return "something";
    }
    public void ShortDescriptionMessage() {
        Console.WriteLine($"Event Type: {_eventType}, Event Title: {_eventTitle}, Date: {_data} ");
    }
}