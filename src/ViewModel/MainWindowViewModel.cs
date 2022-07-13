using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace mvvm_bug.ViewModel;

public partial class MainWindowViewModel : ObservableObject
{

    [ObservableProperty]
    private string _someString;


    public MainWindowViewModel()
    {
        _someString = "DefaultText";
    }
}