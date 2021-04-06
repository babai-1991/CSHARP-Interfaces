using System;

namespace Interfaces.Library
{
    public class Triangle:AbstractRegularPolygon
    {
        public Triangle(int sideLength) : base(3, sideLength)
        {
        }

        public override double GetArea()
        {
            return (SideLength * SideLength * Math.Sqrt(3)) / 4;
        }
    }
}
