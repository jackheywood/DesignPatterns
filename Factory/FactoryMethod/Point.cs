namespace Factory.FactoryMethod;

public class Point
{
    private readonly double _x;
    private readonly double _y;

    private Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    // Factory Methods
    public static Point NewCartesianPoint(double x, double y) => new(x, y);
    public static Point NewPolarPoint(double rho, double theta) => new(rho * Math.Cos(theta), rho * Math.Sin(theta));

    public override string ToString() => $"({_x}, {_y})";
}