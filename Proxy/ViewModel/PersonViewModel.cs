using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Proxy.ViewModel;

// View Model
public sealed class PersonViewModel(Person person) : INotifyPropertyChanged
{
    public string? FirstName
    {
        get => person.FirstName;
        set
        {
            if (person.FirstName == value) return;
            person.FirstName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string? LastName
    {
        get => person.LastName;
        set
        {
            if (person.LastName == value) return;
            person.LastName = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(FullName));
        }
    }

    public string? FullName
    {
        get => $"{FirstName} {LastName}".Trim();
        set
        {
            if (value == null)
            {
                FirstName = LastName = null;
                return;
            }

            var items = value.Split();
            if (items.Length > 0) FirstName = items[0];
            if (items.Length > 1) LastName = items[1];
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}