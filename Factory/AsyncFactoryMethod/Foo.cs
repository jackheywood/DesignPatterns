namespace Factory.AsyncFactoryMethod;

public class Foo
{
    private readonly string _syncField;
    private string? _asyncField;

    private Foo(string syncField)
    {
        _syncField = syncField;
    }

    public static Task<Foo> CreateAsync(string syncField)
    {
        var result = new Foo(syncField);
        return result.InitAsync();
    }

    public override string ToString() => $"Sync: {_syncField}, Async: {_asyncField}";

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(500); // e.g. make an API call and initialise fields
        _asyncField = "Async Data";
        return this;
    }
}