using System.Text;

namespace Builder.FluentBuilder;

public class HtmlElement
{
    private const int IndentSize = 2;
    private readonly string _text;

    public readonly List<HtmlElement> Elements = [];
    public string Tag;

    public HtmlElement()
    { }

    public HtmlElement(string tag, string text)
    {
        Tag = tag;
        _text = text;
    }

    public override string ToString() => ToIndentedString(0);

    private string ToIndentedString(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', IndentSize * indent);

        sb.AppendLine($"{i}<{Tag}>");

        if (!string.IsNullOrWhiteSpace(_text))
        {
            sb.Append(new string(' ', IndentSize * (indent + 1)));
            sb.AppendLine(_text);
        }

        foreach (var element in Elements)
        {
            sb.Append(element.ToIndentedString(indent + 1));
        }

        sb.AppendLine($"{i}</{Tag}>");
        return sb.ToString();
    }
}