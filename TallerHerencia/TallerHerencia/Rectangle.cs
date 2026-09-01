namespace Backend;
public class Rectangle : Square
{
    private double _b;

   //Contructor
    public Rectangle(string name,double b, double a) : base(name, a)
    {
        B = b;
        Name = name;
    }

    //propierty

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);

    }

    //Private methods
    public double ValidateB(double value)
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
        return (A*B);
    }

    public override double GetPerimeter()
    {
        return 2*(A+B);
    }
}
