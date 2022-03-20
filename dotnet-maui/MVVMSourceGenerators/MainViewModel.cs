
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Diagnostics;
using System.Diagnostics;

namespace MVVMSourceGenerators;


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

    int count = 0;

    [ICommand]
    async Task Submit()
    {
        Debug.WriteLine("DEBUG INFO: Submitted");

        try
        {
            count++;
            if(count == 1)
                SubmitInfo(null, 5, null);
            else if(count == 2)
                SubmitInfo(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 5, null);
            else if (count == 3)
                SubmitInfo(new[] { 1, 2, 3 }, 5, null);
            else if (count == 4)
                SubmitInfo(new[] { 1, 2, 3 }, 1, null);
            else if (count == 5)
                SubmitInfo(new[] { 1, 2, 3 }, 1, "Hello World");
        }
        catch(Exception ex)
        {
            await App.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
        }
    }

    public void SubmitInfo(int[] array, int index, string text)
    {
        Guard.IsNotNull(array);
        Guard.HasSizeLessThan(array, 10);
        Guard.IsInRangeFor(index, array);
        Guard.IsNotNullOrEmpty(text);

    }

}
