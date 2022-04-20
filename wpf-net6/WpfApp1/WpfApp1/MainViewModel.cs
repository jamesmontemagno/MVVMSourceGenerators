using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace WpfApp1;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    string _firstName = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    string lastName = "";

    public string FullName => $"{FirstName} {LastName}";

    [ICommand]
    void Submit()
    {
        Debug.WriteLine("DEBUG: Submit entered");
        FirstName = string.Empty;
        LastName = string.Empty;
    }
}
