using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace Wpf.ViewModels
{
  internal class AuthViewModel : BindableBase, IDialogAware
  {
    public event Action<IDialogResult>? RequestClose;
    public DelegateCommand CloseCommand { get; }

    private AuthViewModel()
    {
      CloseCommand = new DelegateCommand(Close);
    }

    private void Close()
    {
      RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
    }

    public string Title => "Auth";

    public bool CanCloseDialog()
    {
      return true;
    }

    public void OnDialogClosed() { }

    public void OnDialogOpened(IDialogParameters parameters) { }
  }
}
