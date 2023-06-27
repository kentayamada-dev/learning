using Domain;
using Domain.Repositories;
using Infrastructure.Fake;
using Infrastructure.SQLite;

namespace Infrastructure
{
  public static class Factories
  {
    public static IUserRepository CreateUser()
    {
      return Shared.IsFake ? new UserFake() : new UserSQLite();
    }
  }
}
