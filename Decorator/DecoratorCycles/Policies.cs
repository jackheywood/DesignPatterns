namespace Decorator.DecoratorCycles;

public abstract class ShapeDecoratorCyclePolicy
{
    public abstract bool TypeAdditionAllowed(Type type, IList<Type> allTypes);
    public abstract bool ApplicationAllowed(Type type, IList<Type> allTypes);
}

public class ThrowOnCyclePolicy : ShapeDecoratorCyclePolicy
{
    private static bool Handle(Type type, IList<Type> allTypes)
    {
        if (allTypes.Contains(type))
        {
            throw new InvalidOperationException($"Cycle detected! {type} is already a {type.FullName}!");
        }

        return true;
    }

    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes) => Handle(type, allTypes);
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes) => Handle(type, allTypes);
}

public class CyclesAllowedPolicy : ShapeDecoratorCyclePolicy
{
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes) => true;
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes) => true;
}

public class AbsorbCyclePolicy : ShapeDecoratorCyclePolicy
{
    public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes) => true;
    public override bool ApplicationAllowed(Type type, IList<Type> allTypes) => !allTypes.Contains(type);
}