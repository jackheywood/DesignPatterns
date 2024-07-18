using System.Text;

namespace Proxy.BitFragging;

// Find operators to be used on a list of integers to produce a given output.
// e.g. 1 3 5 7 input, 0 output --> 1-3-5+7=0
// Operators are Subtract, Subtract, Add

public class Problem(IEnumerable<int> numbers, IEnumerable<Operation> operations)
{
    private readonly List<int> _numbers = numbers.ToList();
    private readonly List<Operation> _operations = operations.ToList();

    public int Evaluate()
    {
        var operationGroups = new[]
        {
            new[] { Operation.Mul, Operation.Div },
            new[] { Operation.Add, Operation.Sub },
        };

        startAgain:
        foreach (var group in operationGroups)
        {
            for (var i = 0; i < _operations.Count; i++)
            {
                if (group.Contains(_operations[i]))
                {
                    var result = _operations[i].Call(_numbers[i], _numbers[i + 1]);
                    if (result != (int)result) return int.MinValue;
                    _numbers[i] = (int)result;
                    _numbers.RemoveAt(i + 1);
                    _operations.RemoveAt(i);
                    if (_numbers.Count == 1) return _numbers[0];
                    goto startAgain;
                }
            }
        }

        return _numbers[0];
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var i = 0;

        for (; i < _operations.Count; i++)
        {
            sb.Append(_numbers[i]);
            sb.Append(_operations[i].Name());
        }

        sb.Append(_numbers[i]);
        return sb.ToString();
    }
}