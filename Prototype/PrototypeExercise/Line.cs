namespace Prototype.PrototypeExercise;

public class Line : IDeepCopyable<Line>
{
    public Point End;
    public Point Start;

    public Line DeepCopy() => new() { Start = Start.DeepCopy(), End = End.DeepCopy() };

    public override string ToString() => $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
}