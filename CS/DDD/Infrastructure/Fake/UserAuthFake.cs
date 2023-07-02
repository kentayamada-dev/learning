using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class UserAuthFake : IUserAuthRepository
  {
    private static UserEntity GetFakeUser()
    {
      string fakeUserPath =
        Shared.FakeUserPath
        ?? throw new CustomException($"{nameof(Shared.FakeUserPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      string[] lines = File.ReadAllLines(fakeUserPath);
      string[] value = lines[0].Split(",");

      return new(value[0].ToInt(), value[1].ToNotNullString(), value[2].ToNotNullString(), value[3].ToDateTime(), value[4].ToDateTime());
    }

    public UserEntity Signin(string name, string password)
    {
      return GetFakeUser();
    }

    public UserEntity Signup(string name, string password)
    {
      return GetFakeUser();
    }
  }
}
