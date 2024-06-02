using Singleton.AmbientContext;
using Singleton.DependencyInjection;
using Singleton.Monostate;
using Singleton.PerThread;
using Singleton.SimpleSingleton;
using Singleton.SingletonExercise;
using Singleton.TestabilityIssues;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleSingleton())
    .WithProgram(new TestabilityIssues())
    .WithProgram(new DependencyInjection())
    .WithProgram(new Monostate())
    .WithProgram(new PerThread())
    .WithProgram(new AmbientContext())
    .WithProgram(new SingletonExercise())
    .Build();

await runner.RunAsync();