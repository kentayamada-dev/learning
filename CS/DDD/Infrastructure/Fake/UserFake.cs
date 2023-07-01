using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class UserFake : IUserRepository
  {
    public void Add(string userName, string password) { }

    public UserEntity? GetByName(string userName)
    {
      return new UserEntity(1, "userName", "password", "2018-08-10 11:10:10".ToDateTime(), "2018-08-12 11:10:10".ToDateTime());
    }
  }
}
