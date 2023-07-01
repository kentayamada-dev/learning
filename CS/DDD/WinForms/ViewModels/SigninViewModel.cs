using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class SigninViewModel
  {
    private readonly UserRepository _user;

    internal SigninViewModel()
      : this(Factories.CreateUser()) { }

    internal SigninViewModel(IUserRepository user)
    {
      _user = new UserRepository(user);
      Password = "";
      Name = "";
    }

    public string Password { get; set; }
    public string Name { get; set; }

    internal void Signin()
    {
      _ = _user.Signin(Name, Password);
    }
  }
}
