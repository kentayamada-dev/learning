using Domain.Entities;
using Domain.Exceptions;
using Microsoft.Data.Sqlite;
using static Domain.Exceptions.CustomException;

namespace Domain.Repositories
{
  public sealed class UserAuthRepository : IUserAuthRepository
  {
    private readonly IUserRepository _user;

    public UserAuthRepository(IUserRepository user)
    {
      _user = user;
    }

    public UserEntity Signin(string name, string password)
    {
      AuthUserEntity tempUser = new(name, password);
      UserEntity? user = _user.GetByName(tempUser.Name.DisplayValue);

      return user == null || user.Password.Value != tempUser.Password.DisplayValue
        ? throw new CustomException("Incorrect Name or Password.", ExceptionKind.Error)
        : user;
    }

    public UserEntity Signup(string name, string password)
    {
      try
      {
        _user.Add(new(name, password));
      }
      catch (SqliteException exception)
      {
        throw new CustomException("Username is already taken.", ExceptionKind.Error, exception);
      }

      return _user.GetByName(name) ?? throw new CustomException("User Not Found.", ExceptionKind.Error);
      ;
    }
  }
}
