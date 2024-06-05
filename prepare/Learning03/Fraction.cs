using System.Diagnostics;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
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
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString(int _top,int _bottom)
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue(int _top, int _bottom)
    {
        return (double)_top / (double)_bottom;
    }
}