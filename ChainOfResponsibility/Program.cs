using ChainOfResponsibility.BrokerChain;
using ChainOfResponsibility.MethodChain;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new MethodChain())
    .WithProgram(new BrokerChain())
    .Build();

await runner.RunAsync();