using System;
public class Swimming : Activity
{
    private int _numberOfLaps;
    public Swimming(string data, int lenght) :base(data, lenght) {

    }

    public Swimming(string data, int lenght, int numberOfLaps) :base(data, lenght) {
        _numberOfLaps = numberOfLaps;
    }
    public int GetNumberOfLaps() {
        return _numberOfLaps;
    }
    public void SetNumberOfLaps(int laps) {
        _numberOfLaps = laps;
    }

    public override string GetSummary(){
        return ($"{GetData()} - Swimming ({GetLenght()} mim) - Distance ({GetDistance()} Km) - Speed ({GetSpeed()} Kph) - Pace ({GetPace()} mim per Km)");
    }
    public override int GetDistance(){
        return (_numberOfLaps * 50 / 1000);
    }
    public override int GetSpeed(){
        return ((GetDistance() / GetLenght()) * 60);
    }
    public override int GetPace(){
        return (GetLenght() / GetDistance());
    }
}