using Backend;
using TallerHerencia;

// Crear figuras geométricas
var circulo = new Circle(name: "Círculo", r: 5);
var cuadrado = new Square(name: "Cuadrado", a: 10);
var rombo = new Rhombus(name: "Rombo", a: 5, d1: 7, d2: 10);
var cometa = new Kite(name: "Cometa", a: 7, b: 8, d1: 6, d2: 5);
var rectangulo = new Rectangle(name: "Rectángulo", a: 4.568, b: 67.790);
var paralelogramo = new Parallelogram(name: "Paralelogramo", a: 14.65, b: 54.67, h: 23.09);
var triangulo = new Triangle(name: "Triángulo", a: 45.56, b: 12.34, c: 27.09, h: 15);
var trapecio = new Trapeze(name: "Trapecio", a: 10, b: 20, c: 30, d: 40, h: 20);

// Lista de figuras
var figuras = new List<GeometricFigure>
{
    circulo,
    cuadrado,
    rombo,
    cometa,
    rectangulo,
    paralelogramo,
    triangulo,
    trapecio
};

// Mostrar cada figura en consola
foreach (var figura in figuras)
{
    Console.WriteLine(figura);
}