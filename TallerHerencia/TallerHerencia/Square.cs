using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TallerHerencia;

namespace Backend;

public class Square : GeometricFigure
{
    //Fields
    private double _a;

    //Contructor
    public Square(double A)

    {
        _a = A;
    }
    //Propiety
    public double A {
        get => _a;
        set => _a =ValidateA(A);
    }

    //Public methods

    public override double GetArea()
    {
        return A * A;

    }

    public override double GetPerimeter()
    {
        return A * 4;
    }

    //Private methods
    private double ValidateA(double A)
    {
        if (A <= 0)
        {
            throw new Exception($"{A},Enter a valid number .");
        }
        return A;

}





}





//Private methods







