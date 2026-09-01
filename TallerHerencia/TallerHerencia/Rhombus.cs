namespace Backend;
public class Rhombus : Square
{
    //Fields
    private double _d1;
    private double _d2;

    //Constructor

    public Rhombus(string name,double a, double d1,double d2) : base(name,a)
    {
    D1 = d1;
    D2 = d2;
    
    }
           
    //Propierty
    public double D1 {
        get => _d1;
        set =>_d1=ValidateD1(value);
    
    }
    public double D2 {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    //Private methods

    private double ValidateD1(double value)
    {
        if (value <= 0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;

    }

    private double ValidateD2(double value)
    { 
    if(value<=0)
        {
            throw new Exception($"{value},Enter a valid number .");
        }
        return value;
    }

    //Public methods
    public override double GetArea()
    {
        return (D1*D2)/2;

    }

    public override double GetPerimeter()
    {
        return A * 4;
    }
 
}
