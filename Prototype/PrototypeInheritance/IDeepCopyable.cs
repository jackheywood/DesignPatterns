namespace Prototype.PrototypeInheritance;

public interface IDeepCopyable<T> where T : new()
{
    void CopyTo(T target);

    T DeepCopy()
    {
        var t = new T();
        CopyTo(t);
        return t;
    }
}