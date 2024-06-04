using Autofac;
using Autofac.Features.Metadata;
using Utilities;

namespace Adapter.DependencyInjection;

public class DependencyInjection() : ConsoleProgram("Adapter in Dependency Injection")
{
    private const string NameKey = "Name";

    public override Task RunAsync()
    {
        var cb = new ContainerBuilder();

        cb.RegisterType<SaveCommand>().As<ICommand>().WithMetadata(NameKey, "Save");
        cb.RegisterType<OpenCommand>().As<ICommand>().WithMetadata(NameKey, "Open");

        cb.RegisterAdapter<Meta<ICommand>, Button>(cmd =>
            new Button(cmd.Value, (string)cmd.Metadata["Name"]));

        cb.RegisterType<Editor>();

        using (var c = cb.Build())
        {
            var editor = c.Resolve<Editor>();
            editor.ClickAll();
            editor.PrintAll();
        }

        return Task.CompletedTask;
    }
}