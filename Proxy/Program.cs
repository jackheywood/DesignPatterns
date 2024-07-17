using Proxy.CompositeProxy.ArrayBacked;
using Proxy.CompositeProxy.SoAAoS;
using Proxy.DynamicProxy;
using Proxy.PropertyProxy;
using Proxy.ProtectionProxy;
using Proxy.ValueProxy;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new ProtectionProxy())
    .WithProgram(new PropertyProxy())
    .WithProgram(new ValueProxy())
    .WithProgram(new CompositeProxySoAAoS())
    .WithProgram(new CompositeProxyArrayBacked())
    .WithProgram(new DynamicProxy())
    .Build();

await runner.RunAsync();