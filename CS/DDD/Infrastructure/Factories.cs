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
#if DEBUG
      if (Shared.IsFake)
      {
        return new WeatherFake();
      }
#endif
      return new WeatherSQLite();
    }
  }
}
