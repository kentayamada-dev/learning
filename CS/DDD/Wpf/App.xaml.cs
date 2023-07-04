using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Services.Dialogs;
using Wpf.Views;

namespace Wpf
{
  public partial class App : PrismApplication
  {
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterDialog<AuthView>();
    }

    protected override Window CreateShell()
    {
      return Container.Resolve<WeatherView>();
    }

    protected override void OnInitialized()
    {
      IDialogService dialog = Container.Resolve<IDialogService>();
      dialog.ShowDialog(
        nameof(AuthView),
        callback =>
        {
          if (callback.Result != ButtonResult.OK)
          {
            Current.Shutdown();
          }
        }
      );
      base.OnInitialized();
    }
  }
}
