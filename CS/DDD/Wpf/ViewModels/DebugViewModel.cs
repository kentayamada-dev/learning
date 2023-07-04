using System;
using Domain;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace Wpf.ViewModels
{
  internal class DebugViewModel : BindableBase, IDialogAware
  {
    public event Action<IDialogResult>? RequestClose;
    public DelegateCommand ProceedCommand { get; }
    public DelegateCommand ExitCommand { get; }

    private DebugViewModel()
    {
      ProceedCommand = new DelegateCommand(Proceed);
      ExitCommand = new DelegateCommand(Exit);
    }

    public static bool IsDebugMode => Shared.IsDebugMode;
    public static bool IsFakeDataMode => Shared.IsFake;
    public string Title => "Debug";

    private void Exit()
    {
      RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
    }

    private void Proceed()
    {
      RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
    }

    public bool CanCloseDialog()
    {
      return true;
    }

    public void OnDialogClosed() { }

    public void OnDialogOpened(IDialogParameters parameters) { }
  }
}
