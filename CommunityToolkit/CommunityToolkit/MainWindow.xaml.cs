namespace CommunityToolkit;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private MainWindowViewModel viewModel;
    public MainWindow()
    {
        DataContext = viewModel = new MainWindowViewModel();
        InitializeComponent();
    }
}