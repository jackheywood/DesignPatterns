using System.Text;

namespace Flyweight.TextFormatting;

public class BetterFormattedText(string plainText)
{
    private readonly List<TextRange> _formatting = [];

    public TextRange GetRange(int start, int end)
    {
        var range = new TextRange { Start = start, End = end };
        _formatting.Add(range);
        return range;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
            
        for (var i = 0; i < plainText.Length; i++)
        {
            var c = plainText[i];
            
            foreach (var range in _formatting)
            {
                if (range.Covers(i) && range.Capitalize)
                {
                    c = char.ToUpper(c);
                }
            }

            sb.Append(c);
        }

        return sb.ToString();
    }

    public class TextRange
    {
        public bool Capitalize, Bold, Italic;
        public int Start, End;

        public bool Covers(int position) => position >= Start && position <= End;
    }
}