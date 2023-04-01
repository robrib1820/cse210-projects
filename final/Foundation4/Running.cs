using System;
public class Running : Activity
{
    private int _runningDistance;

    public Running(string data, int lenght) :base(data, lenght) {
        
    }
    public Running(string data, int lenght, int runningDistance) :base(data, lenght) {
        _runningDistance = runningDistance;
    }
    public int GetRunningDistance() {
        return _runningDistance;
    }
    public void SetRunningDistance(int runningDistance) {
        _runningDistance = runningDistance;
    }

    public override string GetSummary(){
        return ($"{GetData()} - Running ({GetLenght()} mim) - Distance ({GetDistance()} Km) - Speed ({GetSpeed()} Kph) - Pace ({GetPace()} mim per Km)");
    }
    public override int GetDistance(){
        return _runningDistance;
    }
    public override int GetSpeed(){
        return (_runningDistance / GetLenght()) * 60;
    }
    public override int GetPace(){
        return GetLenght() / _runningDistance; 
    }
}