using System;

public class Lectures : Event
{
    private string _speakerName;
    private int _peopleCapacity;

    public Lectures(string speakerName, int peopleCapacity, string eventTitle, string description, string data, string time, string address, string eventType, string specificInformation) : base(eventTitle, description, data, time, address, eventType, specificInformation) {
        _speakerName = speakerName;
        _peopleCapacity = peopleCapacity;
    }
    public string GetSpeakerName() {
        return _speakerName;
    }
    public void SetSpeakerName(string SpeakerName) {
        _speakerName = SpeakerName;
    }
    public int GetPeopleCapacity() {
        return _peopleCapacity;
    }
    public void SetPeopleCapacity(int PeopleCapacity) {
        _peopleCapacity = PeopleCapacity;
    }
    public string LecturesStandardDetails() {
        return "something";
    }
    public void LecturesFullDetails() {
        StandardDetailsMessage();
        Console.WriteLine($"Speaker: {_speakerName} - People Capacity: {_peopleCapacity}");
    }
    public string LecturesShortDescription() {
        return "something";
    }
}