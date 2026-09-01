namespace Backend;
public class Triangle : Rectangle
{
    //Fields
    private double _c;
    private double _h;

    public Triangle(string name,double c,double h, double b, double a) : base(name, b, a)
    {
        C = c;
        H = h;
    }

    //Propierties
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    //Private methods
    private double ValidateC(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;
    }
    private double ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;
    }

    //Public methods
    public override double GetArea()
    {
        return (B*H)/2;
    }

    public override double GetPerimeter()
    {
        return (A+B+C);
    }
}
