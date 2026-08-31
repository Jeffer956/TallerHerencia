using Backend;
using TallerHerencia;


var cuadrado = new Square(name: "Square", a: 10);
var circulo = new Circle(name: "Círcle", r: 5);

// Lista de figuras
var figuras = new List<GeometricFigure>
{

    cuadrado,
    circulo,

};

// Mostrar cada figura en consola
foreach (var figura in figuras)
{
    Console.WriteLine(figura);
}