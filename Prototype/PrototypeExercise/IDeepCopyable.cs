namespace Prototype.PrototypeExercise;

public interface IDeepCopyable<out T>
{
    T DeepCopy();
}