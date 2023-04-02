using System;
public abstract class Activity
{
    private string _data;
    private int _lenght;

    public Activity(string data, int lenght) {
        _data = data;
        _lenght = lenght;
    }
    public int GetLenght() {
        return _lenght;
    }
    public string GetData() {
        return _data;
    }
    public virtual string GetSummary(){
        return "";
    }
    public virtual double GetDistance(){
        return -1;
    }
    public virtual double GetSpeed(){
        return -1;
    }
    public virtual double GetPace(){
        return -1;
    }

}
