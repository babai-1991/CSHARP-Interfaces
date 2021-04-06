using System;

namespace Interfaces.Library
{
    public class ConcretePolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        public ConcretePolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //calculation of area changes on different shapes
        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
