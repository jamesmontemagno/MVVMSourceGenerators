using Microsoft.UI.Xaml.Controls;

using MVVMSourceGenerators.ViewModels;

namespace MVVMSourceGenerators.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
