using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public string GetFractionString () {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue () {
        return (double)_top / (double)_bottom;
    }

    public void setTop(int number) {
        _top = number;
    }

    public void setBottom(int number) {
        _bottom = number;
    }
    public Fraction() {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int topNumber) {
        _top = topNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)  {
        _top = topNumber;
        _bottom = bottomNumber;
    }


}