namespace TallerHerencia;

public abstract class GeometricFigure
{

    //Propiertes

    public string Name { get; set; } = string.Empty;


    //Methods 

    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()

    {

        return $"{Name,-15}=> Area.....:   {GetArea(),11:N5}       Perimeter:   {GetPerimeter(),10:N5}";
    }

}

