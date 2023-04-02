using System;
public class Cycling : Activity
{
    private int _cyclingSpeed;
    public Cycling(string data, int lenght) :base(data, lenght) {

    }
    public Cycling(string data, int lenght, int cyclingSpeed ) :base(data, lenght) {
        _cyclingSpeed = cyclingSpeed;
    }
    public int GetCyclingSpeed() {
        return _cyclingSpeed;
    }
    public void SetCyclingSpeed(int speed){
        _cyclingSpeed = speed;
    }

    public override string GetSummary(){
        return ($"{GetData()} - Cycling ({GetLenght()} mim) - Distance ({GetDistance()} Km) - Speed ({GetSpeed()} Kph) - Pace ({GetPace()} mim per Km)");
    }
    public override double GetDistance(){
        return ((GetSpeed() * GetLenght()) / 1000);
    }
    public override double GetSpeed(){
        return (60 / GetPace());
    }
    public override double GetPace(){
        return (60 / _cyclingSpeed);
    }
}