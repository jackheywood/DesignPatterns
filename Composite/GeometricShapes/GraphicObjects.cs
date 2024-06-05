using System.Text;

namespace Composite.GeometricShapes;

public class GraphicObject
{
    private readonly Lazy<List<GraphicObject>> _children = new();

    public string Colour;
    private List<GraphicObject> Children => _children.Value;
    public virtual string Name { get; set; } = "Group";

    public override string ToString()
    {
        var sb = new StringBuilder();
        Print(sb, 0);
        return sb.ToString();
    }

    public void AddChild(GraphicObject child) => Children.Add(child);

    private void Print(StringBuilder sb, int depth)
    {
        sb.Append(new string('\u2014', depth))
            .Append(depth > 0 ? " " : string.Empty)
            .Append(!string.IsNullOrWhiteSpace(Colour) ? $"{Colour} " : string.Empty)
            .AppendLine($"{Name}");

        foreach (var child in Children) child.Print(sb, depth + 1);
    }
}

public class Circle : GraphicObject
{
    public override string Name => "Circle";
}

public class Square : GraphicObject
{
    public override string Name => "Square";
}