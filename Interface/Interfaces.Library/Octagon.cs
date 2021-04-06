using System;

namespace Interfaces.Library
{
    public class Octagon : IRegularPolygon
    {
        public Octagon(int sideLength)
        {
            NumberOfSides = 8;
            SideLength = sideLength;
        }
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
    }
}
