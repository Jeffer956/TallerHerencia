namespace TallerHerencia;

public abstract class GeometricFigure
{
    //Propiertes

    public string Name { get; set; }


    //Methods 

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {

        return $"{Name}- Area:{GetArea:D4}/Perimeter:{GetPerimeter:D4}";
    }

}

