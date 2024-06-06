namespace Decorator.DefaultInterfaceMembers;

public class MythicalBeast
{
    public int Rarity { get; set; }
}

public class Dragon : MythicalBeast, IBird, ILizard
{
    public int Age { get; set; }
}