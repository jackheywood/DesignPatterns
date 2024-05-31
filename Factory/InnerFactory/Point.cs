namespace Factory.InnerFactory;

public class Point
{
    private readonly double _x;
    private readonly double _y;

    private Point(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public override string ToString() => $"({_x}, {_y})";

    // Internal class allows us to keep the constructor private
    public static class Factory
    {
        public static Point NewCartesianPoint(double x, double y) => new(x, y);

        public static Point NewPolarPoint(double rho, double theta) =>
            new(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}