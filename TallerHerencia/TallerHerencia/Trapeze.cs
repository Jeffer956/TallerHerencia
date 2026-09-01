namespace Backend;

public class Trapeze : Triangle
{
    //Fields

    private double _d; 
        
    //Constructor
    public Trapeze(string name,double d, double c, double h, double b, double a) : base(name, c, h, b, a)
    {
        D = d;
    }

    //Propierty
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }
    
    //Private methods
    public double ValidateD(double value)
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
        return(B+D)*H/2;
    }

    public override double GetPerimeter()
    {
        return A+B+C+D;
    }
}
