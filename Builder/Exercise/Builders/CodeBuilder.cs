using System.Text;

namespace Builder.Exercise.Builders;

public class CodeBuilder
{
    private readonly Code _code = new();

    public CodeBuilder(string className)
    {
        _code.ClassName = className;
    }

    public CodeBuilder AddField(string name, string type)
    {
        _code.Fields.Add(new Field
        {
            Name = name,
            Type = type,
        });

        return this;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder
            .AppendLine($"public class {_code.ClassName}")
            .AppendLine("{");

        foreach (var field in _code.Fields)
        {
            stringBuilder.AppendLine($"  public {field.Type} {field.Name};");
        }

        stringBuilder.Append('}');

        return stringBuilder.ToString();
    }
}