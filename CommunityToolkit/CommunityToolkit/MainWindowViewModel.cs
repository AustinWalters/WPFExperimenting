using CommunityToolkit.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkit;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _fullName = string.Empty;
    [ObservableProperty]
    private string? _badge = string.Empty;

    private User? Employee;

    public MainWindowViewModel()
    {

    }

    [RelayCommand()]
    private void Login()
    {
        Employee = new User(Badge);
        Employee.SetName("John Doe");
        FullName = Employee.FullName;
    }

    [RelayCommand()]
    private void Reset()
    {
        FullName = string.Empty;
        Badge = string.Empty;
        Employee = null;
    }

}
