namespace Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Property
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Constructor
    public Square(string name, double a)
    {
        Name = name;
        A = a;
    }

    // Private methods
    private double ValidateA(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;
    }

    // Public methods
    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return A * 4;
    }
}














