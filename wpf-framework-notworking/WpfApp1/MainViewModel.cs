using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Threading.Tasks;

namespace WpfApp1;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
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
        this.FirstName = "test";
    }

}
