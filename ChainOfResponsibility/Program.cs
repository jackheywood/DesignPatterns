using ChainOfResponsibility.BrokerChain;
using ChainOfResponsibility.ChainOfResponsibilityExercise;
using ChainOfResponsibility.MethodChain;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new MethodChain())
    .WithProgram(new BrokerChain())
    .WithProgram(new ChainOfResponsibilityExercise())
    .Build();

await runner.RunAsync();