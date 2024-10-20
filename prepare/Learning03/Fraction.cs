using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}