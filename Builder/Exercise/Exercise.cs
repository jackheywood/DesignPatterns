using Builder.Exercise.Builders;

namespace Builder.Exercise;

public class Exercise
{
    public static void Run()
    {
        var cb = new CodeBuilder("Person")
            .AddField("Name", "string")
            .AddField("Age", "int");
        
        Console.WriteLine(cb);
    }
}