using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class SignupViewModel
  {
    private readonly UserRepository _user;

    internal SignupViewModel()
      : this(Factories.CreateUser()) { }

    internal SignupViewModel(IUserRepository user)
    {
      _user = new UserRepository(user);
      Password = "";
      Name = "";
    }

    public string Password { get; set; }
    public string Name { get; set; }

    internal void Signup()
    {
      _ = _user.Signup(Name, Password);
    }
  }
}
