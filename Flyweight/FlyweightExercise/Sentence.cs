namespace Flyweight.FlyweightExercise;

public class Sentence(string plainText)
{
    private readonly Dictionary<int, WordToken> _tokens = new();
    private readonly string[] _words = plainText.Split(' ');

    public WordToken this[int index]
    {
        get
        {
            if (_tokens.TryGetValue(index, out var token)) return token;

            var wt = new WordToken();
            _tokens.Add(index, wt);
            return _tokens[index];
        }
    }

    public override string ToString()
    {
        var words = _words
            .Select((word, index) =>_tokens.TryGetValue(index, out var token) && token.Capitalize
                ? word.ToUpperInvariant()
                : word)
            .ToList();

        return string.Join(" ", words);
    }

    public class WordToken
    {
        public bool Capitalize;
    }
}