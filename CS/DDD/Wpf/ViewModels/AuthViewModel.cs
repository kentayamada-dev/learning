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
    public DelegateCommand CloseCommand { get; }
    public DelegateCommand AuthCommand { get; }
    public DelegateCommand ToggleAuthCommand { get; }
    private bool _isSignup;
    private readonly IUserAuthRepository _user;

    private AuthViewModel()
  : this(Factories.CreateUser()) { }

    private AuthViewModel(IUserAuthRepository user)
    {
      _user = user;
      CloseCommand = new DelegateCommand(Close);
      AuthCommand = new DelegateCommand(Auth);
      ToggleAuthCommand = new DelegateCommand(ChangeAuthMode);
      Password = "";
      Name = "";
      _isSignup = true;
      _authModeLabel = "SIGN UP";
      _toggleAuthLabel = "Sign In?";
    }

    private void Close()
    {
      RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
    }

    public string Title => "Auth";
    public string Password { get; set; }
    public string Name { get; set; }

    private string _authModeLabel;
    public string AuthModeLabel
    {
      get => _authModeLabel;
      set => SetProperty(ref _authModeLabel, value);
    }

    private string _toggleAuthLabel;
    public string ToggleAuthLabel
    {
      get => _toggleAuthLabel;
      set => SetProperty(ref _toggleAuthLabel, value);
    }

    private void Auth()
    {
      UserEntity user = _isSignup ? _user.Signup(Name, Password) : _user.Signin(Name, Password);
      Shared.User = new(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);
    }

    private void ChangeAuthMode()
    {
      ToggleAuthLabel = _isSignup ? "Sign Up?" : "Sign In?";
      AuthModeLabel = _isSignup ? "SIGN IN" : "SIGN UP";
      _isSignup = !_isSignup;
    }

    public bool CanCloseDialog()
    {
      return true;
    }

    public void OnDialogClosed() { }

    public void OnDialogOpened(IDialogParameters parameters) { }
  }
}
