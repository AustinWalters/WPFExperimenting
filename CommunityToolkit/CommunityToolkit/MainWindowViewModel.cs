using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Input;

namespace CommunityToolkit;
public record class UserLoggedIn(string UserName);

[ObservableObject]
[ObservableRecipient]
public partial class MainWindowViewModel : IRecipient<UserLoggedIn>
{
    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(ClickCommand))]
    private string? _firstName = "John";

    public MainWindowViewModel(IMessenger messenger)
    {
        this.Messenger = messenger;
    }

    private void Foo()
    {
        IMessenger messenger = this.Messenger;
        messenger.Register<UserLoggedIn>(this);

        messenger.Send(new UserLoggedIn("Johnny"));
    }

    public void Receive(UserLoggedIn message)
    {
        throw new NotImplementedException();
    }

    [RelayCommand(IncludeCancelCommand = true)]
    private async Task Click(CancellationToken token)
    {
        try
        {
            await Task.Delay(5_000, token);
            FirstName += " Doe";
        }
        catch (OperationCanceledException)
        {
            FirstName += " x ";
        }
    }
}
