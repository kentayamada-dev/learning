using Domain;
using Domain.Repositories;
using Infrastructure.Fake;
using Infrastructure.SQLite;

namespace Infrastructure
{
  public static class Factories
  {
    public static IWeatherRepository CreateWeather()
    {
      return Shared.IsFake ? new WeatherFake() : new WeatherSQLite();
    }

    public static IUserRepository CreateUser()
    {
      return Shared.IsFake ? new UserFake() : new UserSQLite();
    }
  }
}
