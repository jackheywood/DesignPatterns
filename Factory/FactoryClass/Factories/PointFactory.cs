namespace Factory.FactoryClass.Factories;

public static class PointFactory
{
    public static Point NewCartesianPoint(double x, double y) => new(x, y);

    public static Point NewPolarPoint(double rho, double theta) => new(rho * Math.Cos(theta), rho * Math.Sin(theta));
}