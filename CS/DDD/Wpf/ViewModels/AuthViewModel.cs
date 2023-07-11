using System;
using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace Wpf.ViewModels
{
  internal class AuthViewModel : BindableBase, IDialogAware
  {
    public event Action<IDialogResult>? RequestClose;
    private bool _isSigin = true;
    private readonly IUserAuthRepository _user;

    private AuthViewModel()
      : this(Factories.CreateUser()) { }

    private AuthViewModel(IUserAuthRepository user)
    {
      _user = user;
    }

    public string Title => "Auth";
    public string Password { get; set; } = "";
    public string Name { get; set; } = "";

    private string _authModeLabel = "SIGN IN";
    public string AuthModeLabel
    {
      get => _authModeLabel;
      set => SetProperty(ref _authModeLabel, value);
    }

    private string _toggleAuthLabel = "Sign Up?";
    public string ToggleAuthLabel
    {
      get => _toggleAuthLabel;
      set => SetProperty(ref _toggleAuthLabel, value);
    }

    private DelegateCommand? _toggleAuthCommand;
    public DelegateCommand ToggleAuthCommand => _toggleAuthCommand ??= new DelegateCommand(ChangeAuthMode);

    private DelegateCommand? _authCommand;
    public DelegateCommand AuthCommand => _authCommand ??= new DelegateCommand(Auth);

    private DelegateCommand? _closeCommand;
    public DelegateCommand CloseCommand => _closeCommand ??= new DelegateCommand(Close);

    private void Close()
    {
      RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
    }

    private void Auth()
    {
      try
      {
        UserEntity user = _isSigin ? _user.Signin(Name, Password) : _user.Signup(Name, Password);
        Shared.User = new(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);
        RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
      }
      catch (Exception Ex)
      {
        App.BaseExceptionProc(Ex);
      }
    }

    private void ChangeAuthMode()
    {
      ToggleAuthLabel = _isSigin ? "Sign In?" : "Sign Up?";
      AuthModeLabel = _isSigin ? "SIGN UP" : "SIGN IN";
      _isSigin = !_isSigin;
    }

    public bool CanCloseDialog()
    {
      return true;
    }

    public void OnDialogClosed() { }

    public void OnDialogOpened(IDialogParameters parameters) { }
  }
}
