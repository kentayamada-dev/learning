using Domain.Entities;
using Domain.Exceptions;
using Domain.ValueObjects;
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
      ValidateAuthInput(name, password);
      UserEntity? user = _user.GetByName(name);

      return user == null || user.Password.Value != password
        ? throw new CustomException("Incorrect Name or Password.", ExceptionKind.Error)
        : user;
    }

    public UserEntity Signup(string name, string password)
    {
      try
      {
        ValidateAuthInput(name, password);
        _user.Add(name, password);
      }
      catch (SqliteException exception)
      {
        throw new CustomException("Username is already taken.", ExceptionKind.Error, exception);
      }

      return _user.GetByName(name) ?? throw new CustomException("User Not Found.", ExceptionKind.Error);
      ;
    }

    private static void ValidateAuthInput(string name, string password)
    {
      _ = new Name(name);
      _ = new Password(password);
    }
  }
}
