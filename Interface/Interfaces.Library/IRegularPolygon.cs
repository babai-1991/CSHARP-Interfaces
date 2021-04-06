namespace Interfaces.Library
{
    public interface IRegularPolygon
    {
        //in interfaces, all members must be declared not implemented
        //All of the interfaces members are automatically public
        int NumberOfSides { get; set; }
        int SideLength { get; set; }

        double GetArea();
        double GetPerimeter();
    }
}
