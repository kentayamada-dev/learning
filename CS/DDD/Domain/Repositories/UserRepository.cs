using Domain.Entities;
using Domain.Exceptions;
using Domain.ValueObjects;
using static Domain.Exceptions.CustomException;

namespace Domain.Repositories
{
  public sealed class UserRepository
  {
    private readonly IUserRepository _user;

    public UserRepository(IUserRepository user)
    {
      _user = user;
    }

    public UserEntity? Signin(string name, string password)
    {
      UserEntity? user = _user.GetByName(name);

      if (user == null || user.Password.Value != password)
      {
        throw new CustomException("Incorrect Name or Password.", ExceptionKind.Error);
      }

      Shared.User = new UserEntity(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);

      return user;
    }

    public UserEntity? Signup(string name, string password)
    {
      Name.Validator(name);
      Password.Validator(password);

      if (_user.GetByName(name) != null)
      {
        throw new CustomException("Username is already taken.", ExceptionKind.Error);
      }

      _user.Add(name, password);

      UserEntity? user = _user.GetByName(name) ?? throw new CustomException("User Not Found.", ExceptionKind.Error);
      Shared.User = new UserEntity(user.ID.Value, user.Name.DisplayValue, user.Password.DisplayValue, user.CreatedAt.Value, user.UpdatedAt.Value);

      return user;
    }
  }
}
