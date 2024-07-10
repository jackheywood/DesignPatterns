using System.Text;

namespace Flyweight.TextFormatting;

public class FormattedText(string plainText)
{
    private readonly bool[] _capitalize = new bool[plainText.Length];

    public void Capitalize(int start, int end)
    {
        for (var i = start; i <= end; i++) _capitalize[i] = true;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        for (var i = 0; i < plainText.Length; i++)
        {
            var c = plainText[i];
            sb.Append(_capitalize[i] ? char.ToUpper(c) : c);
        }

        return sb.ToString();
    }
}