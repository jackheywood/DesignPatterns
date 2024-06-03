using Adapter.AdapterCaching;
using Adapter.SimpleAdapter;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new SimpleAdapter())
    .WithProgram(new AdapterCaching())
    .Build();

await runner.RunAsync();