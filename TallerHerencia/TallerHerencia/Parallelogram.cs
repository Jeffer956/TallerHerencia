namespace Backend;
public class Parallelogram : Rectangle
{
    //fields
    private double _h;

    //Constructor
    public Parallelogram(string name,double h, double b, double a) : base(name, b, a)
    {
        H= h;

    }

    //Propierty
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    
    }

    //Private methods
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
        return(B*H);
    }

    public override double GetPerimeter()
    {
        return (A+B)*2;
    }
}
