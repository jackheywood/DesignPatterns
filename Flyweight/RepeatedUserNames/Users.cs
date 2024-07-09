namespace Flyweight.RepeatedUserNames;

public class User(string fullName)
{
    public string FullName { get; } = fullName;
}

public class User2
{
    private static readonly List<string> Strings = [];
    private readonly int[] _names;

    public User2(string fullName)
    {
        _names = fullName.Split(' ').Select(GetOrAdd).ToArray();
        return;

        int GetOrAdd(string s)
        {
            var i = Strings.IndexOf(s);
            if (i != -1) return i;
            Strings.Add(s);
            return Strings.Count - 1;
        }
    }

    public string FullName => string.Join(' ', _names.Select(i => Strings[i]));
}