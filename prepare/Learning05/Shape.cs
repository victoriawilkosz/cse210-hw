using System;

public class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Virtual method for calculating area
    public virtual double GetArea()
    {
        // Base implementation returns 0, subclasses should override this method
        return 0;
    }
}