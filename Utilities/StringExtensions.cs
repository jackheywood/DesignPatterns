namespace Utilities;

public static class StringExtensions
{
    public static string CapitalizeFirstLetter(this string s)
    {
        return s.Length switch
        {
            0 => s,
            1 => char.ToUpper(s[0]).ToString(),
            _ => char.ToUpper(s[0]) + s[1..],
        };
    }
}