namespace Prototype.PrototypeInheritance.Extensions;

public static class DeepCopyableExtensions
{
    public static T DeepCopy<T>(this IDeepCopyable<T> item) where T : new() => item.DeepCopy();

    public static T DeepCopy<T>(this T person) where T : Person, new() => ((IDeepCopyable<T>)person).DeepCopy();
}