using Squirrel;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace CommunityToolkit;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    private MainWindowViewModel viewModel;
    readonly DispatcherTimer UpdateTimer = new();
    public MainWindow()
    {
        DataContext = viewModel = new MainWindowViewModel();
        InitializeComponent();
        SquirrelAwareApp.HandleEvents(
            onInitialInstall: OnAppInstall,
            onAppUninstall: OnAppUninstall,
            onEveryRun: OnAppRun
            );
        UpdateTimer.Interval = TimeSpan.FromMinutes(5);
        UpdateTimer.Tick += UpdateTimer_Tick;
        UpdateTimer.Start();
    }

    private void UpdateTimer_Tick(object? sender, EventArgs e)
    {
        UpdateMyApp();
    }

    private void OnAppRun(SemanticVersion version, IAppTools tools, bool firstRun)
    {
        tools.SetProcessAppUserModelId();
        // show a welcome message when the app is first installed
        if (firstRun) MessageBox.Show("Thanks for installing my application!");
    }

    private void OnAppUninstall(SemanticVersion version, IAppTools tools)
    {
        tools.RemoveShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
    }

    private void OnAppInstall(SemanticVersion version, IAppTools tools)
    {
        tools.CreateShortcutForThisExe(ShortcutLocation.StartMenu | ShortcutLocation.Desktop);
    }
    //TODO: Make good way to call this periodically and check for updates. Should probably be a new thread started on startup that runs this method every so often. Every few minutes?
    private static async Task UpdateMyApp()
    {
        using var mgr = new UpdateManager("https://the.place/you-host/updates");
        var newVersion = await mgr.UpdateApp();

        // optionally restart the app automatically, or ask the user if/when they want to restart
        if (newVersion != null)
        {
            UpdateManager.RestartApp();
        }
    }

    private void BadgePWB_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
    {
        if (BadgePWB.Password.Length < 5)
        {
            return;
        }
        viewModel.Password = BadgePWB.Password;
    }
}