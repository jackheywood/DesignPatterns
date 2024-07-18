using ChainOfResponsibility.MethodChain;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new MethodChain())
    .Build();

await runner.RunAsync();