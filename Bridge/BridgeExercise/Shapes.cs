namespace Bridge.BridgeExercise;

public abstract class Shape(IRenderer renderer)
{
    protected string Name { get; init; }

    public override string ToString() => $"Drawing {Name} as {renderer.WhatToRenderAs}";
}

public class Triangle : Shape
{
    public Triangle(IRenderer renderer) : base(renderer)
    {
        Name = "Triangle";
    }
}

public class Square : Shape
{
    public Square(IRenderer renderer) : base(renderer)
    {
        Name = "Square";
    }
}