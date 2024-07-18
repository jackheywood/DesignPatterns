using System.ComponentModel;

namespace Proxy.BitFragging;

public enum Operation : byte
{
    [Description("*")] Mul = 0,
    [Description("/")] Div = 1,
    [Description("+")] Add = 2,
    [Description("-")] Sub = 3,
}

public static class OperationImplementation
{
    private static readonly Dictionary<Operation, char> OperationNames = new();

    // Notice the data types!
    private static readonly Dictionary<Operation, Func<double, double, double>> OperationImplementations = new()
    {
        [Operation.Mul] = (x, y) => x * y,
        [Operation.Div] = (x, y) => x / y,
        [Operation.Add] = (x, y) => x + y,
        [Operation.Sub] = (x, y) => x - y,
    };

    static OperationImplementation()
    {
        var type = typeof(Operation);
        foreach (Operation op in Enum.GetValues(type))
        {
            var memberInfo = type.GetMember(op.ToString());
            if (memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attributes.Length > 0) OperationNames[op] = ((DescriptionAttribute)attributes[0]).Description[0];
            }
        }
    }

    public static double Call(this Operation operation, int x, int y)
    {
        return OperationImplementations[operation](x, y);
    }

    public static char Name(this Operation operation)
    {
        return OperationNames[operation];
    }
}