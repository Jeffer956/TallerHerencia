using Backend;
using TallerHerencia;


var cuadrado = new Square(name: "Square", a: 10);
var circulo = new Circle(name: "Circle", r: 5);
var rombo = new Rhombus(name: "Rhombus", a: 5, d1: 7, d2: 10);
var cometa = new Kite(name: "Kite", a: 7, b: 8, d1: 6, d2: 5);

// Lista de figuras
var figuras = new List<GeometricFigure>
{

    cuadrado,
    circulo,
    rombo,
    cometa,


};

// Mostrar cada figura en consola
foreach (var figura in figuras)
{
    Console.WriteLine(figura);
}