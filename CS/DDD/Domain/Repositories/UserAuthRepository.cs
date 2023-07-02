using Domain.Entities;
using Domain.Exceptions;
using Domain.ValueObjects;
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
      UserEntity? user = _user.GetByName(name);

      return user == null || user.Password.Value != password ? throw new CustomException("Incorrect Name or Password.", ExceptionKind.Error) : user;
    }

    public UserEntity Signup(string name, string password)
    {
      Name.Validator(name);
      Password.Validator(password);

      if (_user.GetByName(name) != null)
      {
        throw new CustomException("Username is already taken.", ExceptionKind.Error);
      }

      _user.Add(name, password);

      return _user.GetByName(name) ?? throw new CustomException("User Not Found.", ExceptionKind.Error);
      ;
    }
  }
}
