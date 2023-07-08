using System;
using System.Windows;
using Domain;
using Domain.Exceptions;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Regions;
using Prism.Services.Dialogs;
using Wpf.Views;

namespace Wpf
{
  public partial class App : PrismApplication
  {
    internal static void BaseExceptionProc(Exception exception)
    {
      MessageBoxImage icon = MessageBoxImage.None;
      string caption = "";
      if (exception is CustomException customException)
      {
        if (customException.Kind == CustomException.ExceptionKind.Information)
        {
          icon = MessageBoxImage.Information;
          caption = "Information";
        }
        else if (customException.Kind == CustomException.ExceptionKind.Warning)
        {
          icon = MessageBoxImage.Warning;
          caption = "Warning";
        }
        else
        {
          icon = MessageBoxImage.Error;
          caption = "Error";
        }
      }
      _ = MessageBox.Show(exception.Message, caption, MessageBoxButton.OK, icon);
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      containerRegistry.RegisterDialog<AuthView>();
      containerRegistry.RegisterDialog<DebugView>();
    }

    protected override Window CreateShell()
    {
      return Container.Resolve<WeatherView>();
    }

    protected override void OnInitialized()
    {
      IDialogService dialog = Container.Resolve<IDialogService>();

      if (Shared.IsDebugMode)
      {
        dialog.ShowDialog(
          nameof(DebugView),
          callback =>
          {
            if (callback.Result != ButtonResult.OK)
            {
              Current.Shutdown();
            }
          }
        );
      }

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

      IRegionManager regionManager = Container.Resolve<IRegionManager>();
      _ = regionManager.RegisterViewWithRegion("UserInfoViewRegion", typeof(UserInfoView));
      _ = regionManager.RegisterViewWithRegion("LatestWeatherViewRegion", typeof(LatestWeatherView));
      _ = regionManager.RegisterViewWithRegion("WeathersListViewRegion", typeof(WeathersListView));

      base.OnInitialized();
    }
  }
}
