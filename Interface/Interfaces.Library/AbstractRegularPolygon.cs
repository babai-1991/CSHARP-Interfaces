namespace Interfaces.Library
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }

        protected AbstractRegularPolygon(int numberOfSides, int sideLength)
        {
            NumberOfSides = numberOfSides;
            SideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }

        //must implement by its child class
        public abstract double GetArea();
    }
}
