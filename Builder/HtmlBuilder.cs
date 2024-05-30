namespace Builder;

public class HtmlBuilder
{
    private readonly string _rootTag;
    private HtmlElement _root = new();

    public HtmlBuilder(string rootTag)
    {
        _rootTag = rootTag;
        _root.Tag = rootTag;
    }

    public void AddChild(string childTag, string childText)
    {
        var childElement = new HtmlElement(childTag, childText);
        _root.Elements.Add(childElement);
    }

    public void Clear()
    {
        _root = new HtmlElement { Tag = _rootTag };
    }

    public override string ToString() => _root.ToString();
}