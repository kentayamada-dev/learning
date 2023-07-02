using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class SignupViewModel
  {
    private readonly IUserAuthRepository _user;

    internal SignupViewModel()
      : this(Factories.CreateUser()) { }

    private SignupViewModel(IUserAuthRepository user)
    {
      _user = user;
      Password = "";
      Name = "";
    }

    public string Password { get; set; }
    public string Name { get; set; }

    internal void Signup()
    {
      UserEntity user = _user.Signup(Name, Password);
      Shared.User = new UserEntity(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);
    }
  }
}
