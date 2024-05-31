namespace Builder.StepwiseBuilder;

public class Car
{
    public CarType Type;
    public int WheelSize;

    public override string ToString() => $"Type: {Type}, Wheel Size: {WheelSize}\"";
}

public enum CarType
{
    Sedan,
    Crossover,
}