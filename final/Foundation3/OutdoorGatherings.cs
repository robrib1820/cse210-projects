using System;

public class OutdoorGatherings : Event
{
    private string _weatherState;
    public OutdoorGatherings(string eventTitle, string description, string data, string time, string address, string eventType, string specificInformation) : base(eventTitle, description, data, time, address, eventType, specificInformation) {

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
    public string OutdoorFullDetails() {
        return "something";
    }
    public string OutdoorShortDescription() {
        return "something";
    }
    
}