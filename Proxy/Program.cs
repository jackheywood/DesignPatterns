using Proxy.BitFragging;
using Proxy.CompositeProxy.ArrayBacked;
using Proxy.CompositeProxy.SoAAoS;
using Proxy.DynamicProxy;
using Proxy.PropertyProxy;
using Proxy.ProtectionProxy;
using Proxy.ProxyExercise;
using Proxy.ValueProxy;
using Proxy.ViewModel;
using Utilities;

var runner = new ProgramRunnerBuilder()
    .WithProgram(new ProtectionProxy())
    .WithProgram(new PropertyProxy())
    .WithProgram(new ValueProxy())
    .WithProgram(new CompositeProxySoAAoS())
    .WithProgram(new CompositeProxyArrayBacked())
    .WithProgram(new DynamicProxy())
    .WithProgram(new ViewModel())
    .WithProgram(new BitFragging())
    .WithProgram(new ProxyExercise())
    .Build();

await runner.RunAsync();