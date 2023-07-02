using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class SigninViewModel
  {
    private readonly IUserAuthRepository _user;

    internal SigninViewModel()
      : this(Factories.CreateUser()) { }

    private SigninViewModel(IUserAuthRepository user)
    {
      _user = user;
      Password = "";
      Name = "";
    }

    public string Password { get; set; }
    public string Name { get; set; }

    internal void Signin()
    {
      UserEntity user = _user.Signin(Name, Password);
      Shared.User = new UserEntity(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);
    }
  }
}
