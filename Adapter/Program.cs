using Adapter.AdapterCaching;
using Adapter.AdapterExercise;
using Adapter.DependencyInjection;
using Adapter.GenericValueAdapter;
using Adapter.SimpleAdapter;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleAdapter())
    .WithProgram(new AdapterCaching())
    .WithProgram(new GenericValueAdapter())
    .WithProgram(new DependencyInjection())
    .WithProgram(new AdapterExercise())
    .Build();

await runner.RunAsync();