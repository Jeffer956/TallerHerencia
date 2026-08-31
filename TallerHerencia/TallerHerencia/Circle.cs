using TallerHerencia;

namespace Backend;

public class Circle : GeometricFigure
{
    // fields
    private double _r;

    //propierty
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    //contructor

    public Circle(string name, double r)
    {
        Name = name;
        R = r;
        

    }
    //private methods
    private double ValidateR(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;

    }

    //public methods
    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);

    }

    public override double GetPerimeter()
    {
        return (2 * Math.PI) * R;
    }

}

