using System;
using Interfaces.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5);
            DisplayPolygon("Square", square);

            Triangle triangle = new Triangle(5);
            DisplayPolygon("Triangle",triangle);

            Octagon octagon = new Octagon(5);
            DisplayPolygon("Octagon",octagon);
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygonType} Perimeter: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Exception was thrown while trying to process {polygonType}:\n   {ex.GetType().Name}");
                Console.WriteLine();
            }
        }
    }
}
