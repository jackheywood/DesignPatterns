using Utilities;

namespace Proxy.BitFragging;

public class BitFragging() : ConsoleProgram("Bit Fragging")
{
    public override Task RunAsync()
    {
        int[] numbers = [1, 3, 5, 7];
        var numberOfOperators = numbers.Length - 1;

        for (var result = 0; result <= 10; result++)
        {
            for (var key = 0UL; key < 1UL << (2 * numberOfOperators); key++)
            {
                var twoBitSet = new TwoBitSet(key);
                var operators = Enumerable.Range(0, numberOfOperators)
                    .Select(i => twoBitSet[i])
                    .Cast<Operation>()
                    .ToArray();

                var problem = new Problem(numbers, operators);
                if (problem.Evaluate() == result) WriteLine($"{new Problem(numbers, operators)} = {result}");
            }
        }

        return Task.CompletedTask;
    }
}