namespace Builder.SimpleFluent.Builders;

public class HtmlBuilder
{
    private readonly string _rootTag;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootTag)
    {
        _rootTag = rootTag;
        _root.Tag = rootTag;
    }

    public HtmlBuilder AddChild(string childTag, string childText)
    {
        var childElement = new HtmlElement(childTag, childText);
        _root.Elements.Add(childElement);
        return this; // Fluent interface
    }

    public void Clear()
    {
        _root = new HtmlElement { Tag = _rootTag };
    }

    public override string ToString() => _root.ToString();
}