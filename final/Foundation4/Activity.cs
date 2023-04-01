using System;
public abstract class Activity
{
    private string _data;
    private int _lenght;
    public Activity() {
        
    }

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
    public virtual int GetDistance(){
        return -1;
    }
    public virtual int GetSpeed(){
        return -1;
    }
    public virtual int GetPace(){
        return -1;
    }

}
