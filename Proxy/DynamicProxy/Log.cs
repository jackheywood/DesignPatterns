using System.Dynamic;
using System.Text;
using ImpromptuInterface;

namespace Proxy.DynamicProxy;

public class Log<T>(T subject) : DynamicObject where T : class, new()
{
    private readonly Dictionary<string, int> _methodCallCount = new();

    private string Info
    {
        get
        {
            var sb = new StringBuilder();
            foreach (var methodCall in _methodCallCount)
            {
                sb.AppendLine($"{methodCall.Key} called {methodCall.Value} time(s)");
            }

            return sb.ToString();
        }
    }

    public static I As<I>() where I : class
    {
        if (!typeof(I).IsInterface) throw new ArgumentException("I must be an interface type!");
        return new Log<T>(new T()).ActLike<I>();
    }

    public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result)
    {
        try
        {
            WriteLine($"Invoking {subject.GetType().Name}.{binder.Name} with arguments [{string.Join(',', args)}]");

            if (!_methodCallCount.TryAdd(binder.Name, 1)) _methodCallCount[binder.Name]++;

            result = subject.GetType().GetMethod(binder.Name)!.Invoke(subject, args);
            return true;
        }
        catch
        {
            result = null;
            return false;
        }
    }

    public override string ToString()
    {
        return $"{Info}\n{subject}";
    }
}