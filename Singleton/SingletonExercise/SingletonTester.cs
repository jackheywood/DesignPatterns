namespace Singleton.SingletonExercise;

public class SingletonTester
{
    public static bool IsSingleton(Func<object> func)
    {
        var object1 = func();
        var object2 = func();
        return ReferenceEquals(object1, object2);
    }
}