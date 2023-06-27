using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class LoginViewModel
  {
    private readonly UserRepository _user;

    internal LoginViewModel()
      : this(Factories.CreateUser()) { }

    internal LoginViewModel(IUserRepository user)
    {
      _user = new UserRepository(user);
      Password = "";
      Name = "";
    }

    public string Password { get; set; }
    public string Name { get; set; }

    internal void Auth()
    {
      _ = _user.Login(Name, Password);
    }
  }
}
