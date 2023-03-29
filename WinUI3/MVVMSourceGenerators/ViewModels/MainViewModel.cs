using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVMSourceGenerators.ViewModels;


public partial class MainViewModel : ObservableRecipient
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    string firstName = "";

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
