namespace Decorator.DecoratorExercise;

public class Bird
{
    public int Age { get; set; }

    public string Fly() => Age < 10 ? "flying" : "too old";
}

public class Lizard
{
    public int Age { get; set; }

    public string Crawl() => Age > 1 ? "crawling" : "too young";
}

public class Dragon
{
    private readonly Bird _bird = new();
    private readonly Lizard _lizard = new();

    private int _age;

    public int Age
    {
        get => _age;
        set => _age = _bird.Age = _lizard.Age = value;
    }

    public string Fly() => _bird.Fly();

    public string Crawl() => _lizard.Crawl();
}