using TallerHerencia;

namespace Backend;

public class Square : GeometricFigure
{
    //Fields
    private double _a;

    //Propiety
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }
    //Contructor
    public Square(string name,double a)

    {
        Name=name;
        A = a;
<<<<<<< HEAD
    }

=======
               
    }
>>>>>>> f9e8d25c5ec7ca284b4afbae65850de9b43af7ae
    //Private methods
    private double ValidateA(double value)
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
        return A * A;

    }
<<<<<<< HEAD

=======
>>>>>>> f9e8d25c5ec7ca284b4afbae65850de9b43af7ae
        public override double GetPerimeter()
    {
        return A * 4;
    }
       }













