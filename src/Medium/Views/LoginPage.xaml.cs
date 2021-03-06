using Avalonia;
using Avalonia.Markup.Xaml;
using Medium.Core.ViewModels;
using ReactiveUI;

namespace Medium.Views
{
    public partial class LoginPage : ReactiveUserControl<LoginViewModel>
    {
        public LoginPage()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
