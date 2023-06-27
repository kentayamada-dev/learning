using Domain.Entities;
using Domain.Exceptions;
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

    public UserEntity? Login(string name, string password)
    {
      UserEntity? user = _user.Get(name) ?? throw new CustomException("User Not Found.", ExceptionKind.Error);
      Shared.UserName = user.Name;

      return user;
    }
  }
}
