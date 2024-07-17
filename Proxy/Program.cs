using Proxy.PropertyProxy;
using Proxy.ProtectionProxy;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new ProtectionProxy())
    .WithProgram(new PropertyProxy())
    .Build();

await runner.RunAsync();