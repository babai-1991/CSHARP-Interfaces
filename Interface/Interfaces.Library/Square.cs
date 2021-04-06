namespace Interfaces.Library
{
    public class Square:ConcretePolygon
    {
        public Square(int sideLength) : base(4, sideLength)
        {

        }

        //public override double GetArea()
        //{
        //    return SideLength * SideLength;
        //}
    }
}
