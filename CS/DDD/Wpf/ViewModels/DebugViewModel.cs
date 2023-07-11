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

    public static bool IsDebugMode => Shared.IsDebugMode;
    public static bool IsFakeDataMode => Shared.IsFake;
    public string Title => "Debug";

    private DelegateCommand? _proceedCommand;
    public DelegateCommand ProceedCommand => _proceedCommand ??= new DelegateCommand(Proceed);

    private DelegateCommand? _exitCommand;
    public DelegateCommand ExitCommand => _exitCommand ??= new DelegateCommand(Exit);

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
