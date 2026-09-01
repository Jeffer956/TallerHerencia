namespace Backend;
public class Kite : Rhombus
{
    //Fields
    private double _b;


    //contructor

    public Kite(string name, double a,double b, double d1, double d2) : base(name, a, d1, d2)
    {
        B= b;

    }
    //Propierties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);

    }

    //Private methods

    private double ValidateB(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;
    }

    //Public Methods
    public override double GetArea()
    {
        return (D1*D2)/2;
    }

    public override double GetPerimeter()
    {
        return 2*(A+B) ;
    }
}
