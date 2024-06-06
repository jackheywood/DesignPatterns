namespace Decorator.MultipleInheritanceInterfaces;

public interface IBird
{
    int Weight { get; set; }
    void Fly();
}

public interface ILizard
{
    int Weight { get; set; }
    void Crawl();
}