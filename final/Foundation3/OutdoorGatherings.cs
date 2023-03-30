using System;

public class OutdoorGatherings : Event
{
    private string _weatherState;
    public OutdoorGatherings(string weatherState, string eventTitle, string description, string data, string time, string eventType, string specificInformation) : base(eventTitle, description, data, time, eventType, specificInformation) {
        _weatherState = weatherState;
    }
    public string GetWeatherState() {
        return _weatherState;
    }
    public void SetWeatherState(string Weather) {
        _weatherState = Weather;
    }
    public string OutdoorStandardDetails() {
        return "something";
    }
    public void OutdoorFullDetails() {
        StandardDetailsMessage();
        Console.WriteLine($"Weather Info: {_weatherState}");
    }
    public string OutdoorShortDescription() {
        return "something";
    }
    
}