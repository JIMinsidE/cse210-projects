using System;

public class Fraction()
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    

public string GetFractionString()
{
    string frac_string = $"{_top}/{_bottom}";
        return frac_string;
}

public double GetDecimalValue()
{
    return (double)_top / (double)_bottom;
}
}