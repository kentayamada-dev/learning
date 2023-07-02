using Domain.Entities;

namespace Domain.Repositories
{
  public interface IUserAuthRepository
  {
    UserEntity Signin(string name, string password);
    UserEntity Signup(string name, string password);
  }
}
