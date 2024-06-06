namespace Decorator.MultipleInheritanceInterfaces;

public class Bird : IBird
{
    public int Weight { get; set; }

    public void Fly()
    {
        WriteLine($"I'm so high but I weigh {Weight}.");
    }
}

public class Lizard : ILizard
{
    public int Weight { get; set; }

    public void Crawl()
    {
        WriteLine($"I'm plodding along weighing {Weight}.");
    }
}

public class Dragon : IBird, ILizard
{
    private readonly Bird _bird = new();
    private readonly Lizard _lizard = new();

    private int _weight;

    public void Fly()
    {
        _bird.Fly();
    }

    public int Weight
    {
        get => _weight;
        set
        {
            _bird.Weight = value;
            _lizard.Weight = value;
            _weight = value;
        }
    }

    public void Crawl()
    {
        _lizard.Crawl();
    }
}