using Proxy.ProtectionProxy;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new ProtectionProxy())
    .Build();

await runner.RunAsync();