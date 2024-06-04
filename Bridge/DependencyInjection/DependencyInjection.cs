using Autofac;
using Utilities;

namespace Bridge.DependencyInjection;

public class DependencyInjection() : ConsoleProgram("Bridge Dependency Injection")
{
    public override Task RunAsync()
    {
        var cb = new ContainerBuilder();

        cb.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance();
        cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0)));

        using (var c = cb.Build())
        {
            var circle = c.Resolve<Circle>(new PositionalParameter(0, 2.7f));

            circle.Draw();
            circle.Resize(3.0f);
            circle.Draw();
        }

        return Task.CompletedTask;
    }
}