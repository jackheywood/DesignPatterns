namespace Factory.BulkReplacement;

public class Ref<T>(T value) where T : class
{
    public T Value = value;
}