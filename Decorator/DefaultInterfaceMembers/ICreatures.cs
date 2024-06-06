namespace Decorator.DefaultInterfaceMembers;

public interface ICreature
{
    int Age { get; set; }
}

public interface IBird : ICreature
{
    void Fly()
    {
        WriteLine(Age >= 10 ? "I am flying" : "I can't fly yet");
    }
}

public interface ILizard : ICreature
{
    void Crawl()
    {
        WriteLine(Age < 10 ? "I am crawling" : "I'm too old to crawl");
    }
}