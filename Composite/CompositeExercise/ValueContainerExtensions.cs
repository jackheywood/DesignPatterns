namespace Composite.CompositeExercise;

public static class ValueContainerExtensions
{
    public static int Sum(this List<IValueContainer> containers)
    {
        return containers.SelectMany(c => c).Sum();
    }
}