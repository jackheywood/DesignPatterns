using Adapter.AdapterCaching;
using Adapter.GenericValueAdapter;
using Adapter.SimpleAdapter;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleAdapter())
    .WithProgram(new AdapterCaching())
    .WithProgram(new GenericValueAdapter())
    .Build();

await runner.RunAsync();