using System;

<<<<<<< HEAD
class Fraction
=======
public class Fraction
>>>>>>> 17f85f8f4249ec6ba29750f4b8714af7a7491c0f
{
    private int _top;
    private int _bottom;

<<<<<<< HEAD
    public string GetFractionString () {
=======
    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
>>>>>>> 17f85f8f4249ec6ba29750f4b8714af7a7491c0f
        string text = $"{_top}/{_bottom}";
        return text;
    }

<<<<<<< HEAD
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


=======
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
>>>>>>> 17f85f8f4249ec6ba29750f4b8714af7a7491c0f
}