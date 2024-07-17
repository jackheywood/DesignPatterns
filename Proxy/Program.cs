using Proxy.PropertyProxy;
using Proxy.ProtectionProxy;
using Proxy.ValueProxy;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new ProtectionProxy())
    .WithProgram(new PropertyProxy())
    .WithProgram(new ValueProxy())
    .Build();

await runner.RunAsync();