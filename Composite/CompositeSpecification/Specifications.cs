namespace Composite.CompositeSpecification;

public abstract class Specification<T>
{
    public abstract bool IsSatisfied(T t);

    public static Specification<T> operator &(Specification<T> first, Specification<T> second) =>
        new AndSpecification<T>(first, second);

    public static Specification<T> operator |(Specification<T> first, Specification<T> second) =>
        new OrSpecification<T>(first, second);
}

public abstract class CompositeSpecification<T>(params Specification<T>[] items) : Specification<T>
{
    protected readonly Specification<T>[] Items = items;
}

public class AndSpecification<T>(params Specification<T>[] items) : CompositeSpecification<T>(items)
{
    public override bool IsSatisfied(T t)
    {
        return Items.All(i => i.IsSatisfied(t));
    }
}

public class OrSpecification<T>(params Specification<T>[] items) : CompositeSpecification<T>(items)
{
    public override bool IsSatisfied(T t)
    {
        return Items.Any(i => i.IsSatisfied(t));
    }
}

public class PositiveSpecification : Specification<int>
{
    public override bool IsSatisfied(int value) => value > 0;
}

public class NegativeSpecification : Specification<int>
{
    public override bool IsSatisfied(int value) => value < 0;
}