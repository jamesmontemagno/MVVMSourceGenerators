
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace MVVMSourceGenerators;


public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
       // this.f
    }

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    string firstName;


    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FullName))]
    string lastName;


    public string FullName => $"{FirstName} {LastName}";


    [ICommand]
    async Task Submit()
    {
        Debug.WriteLine("DEBUG INFO: Submitted");
    }

}
