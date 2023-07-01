using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class UserFake : IUserRepository
  {
    public void Add(string userName, string password) { }

    public UserEntity? GetByName(string userName)
    {
      string fakeUserPath = Shared.FakeUserPath ?? throw new CustomException($"{nameof(Shared.FakeUserPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      string[] lines = File.ReadAllLines(fakeUserPath);
      string[] value = lines[0].Split(",");
      UserEntity user = new(
            value[0].ToInt(),
            value[1].ToNotNullString(),
            value[2].ToNotNullString(),
            value[3].ToDateTime(),
            value[4].ToDateTime()
          );

      return user;
    }
  }
}
