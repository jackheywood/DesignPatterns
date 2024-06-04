namespace Adapter.DependencyInjection;

public class Editor(IEnumerable<Button> buttons)
{
    public void ClickAll()
    {
        foreach (var button in buttons) button.Click();
    }

    public void PrintAll()
    {
        foreach (var button in buttons) button.Print();
    }
}