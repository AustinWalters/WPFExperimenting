using CommunityToolkit.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkit;

public partial class MainWindowViewModel : ObservableObject
{
    private User? Employee;

    [ObservableProperty]
    private string? _fullName = string.Empty;
    [ObservableProperty]
    private string? _password = string.Empty;
    [ObservableProperty]
    private string? _error = string.Empty;

    public MainWindowViewModel()
    {

    }

    [RelayCommand()]
    private void Login()
    {
        if (Password == null || Password.Length == 0)
        {
            Error = "Please scan your badge";
            return;
        }
        if (!Password.ToUpper().Contains("OP"))
        {
            Error = "Please scan a valid badge";
            return;
        }
        Employee = new User(Password);
        Employee.SetName("John Doe");
        FullName = Employee.FullName;
    }

    [RelayCommand()]
    private void Reset()
    {
        FullName = string.Empty;
        Password = string.Empty;
        Employee = null;
    }

    [RelayCommand()]
    private void Settings()
    {
        FullName = "Settings pressed";
    }
}
