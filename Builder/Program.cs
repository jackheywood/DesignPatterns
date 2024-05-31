using Builder.Exercise;
using Builder.Faceted;
using Builder.FluentInheritance;
using Builder.Functional;
using Builder.SimpleFluent;
using Builder.Stepwise;
using ConsoleRunner;

var runner = new ProgramRunnerBuilder()
    .WithProgram(ConsoleKey.D1, new SimpleFluent())
    .WithProgram(ConsoleKey.D2, new FluentInheritance())
    .WithProgram(ConsoleKey.D3, new Stepwise())
    .WithProgram(ConsoleKey.D4, new Functional())
    .WithProgram(ConsoleKey.D5, new Faceted())
    .WithProgram(ConsoleKey.D6, new Exercise())
    .Build();

runner.Run();