namespace Prototype.DeepCopyInterface;

public interface IPrototype<out T>
{
    T DeepCopy();
}