using Utilities;

namespace Proxy.ViewModel;

public class ViewModel() : ConsoleProgram("View Model")
{
    public override Task RunAsync()
    {
        var person = new Person("Jack", "Heywood");
        var viewModel = new PersonViewModel(person);
        
        WriteLine(viewModel.FullName);

        viewModel.FirstName = "Arlo";
        viewModel.LastName = "Doggy";
        
        WriteLine(viewModel.FullName);

        viewModel.FullName = "Danni Tostevin";
        
        WriteLine(viewModel.FullName);
        
        return Task.CompletedTask;
    }
}