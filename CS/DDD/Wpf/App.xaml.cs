using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using Wpf.Views;

namespace Wpf
{
  public partial class App : PrismApplication
  {
    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }

    protected override Window CreateShell()
    {
      return Container.Resolve<MainWindow>();
    }
  }
}
