using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.SQLite
{
  internal sealed class WeatherSQLite : IWeatherRepository
  {
    public WeatherEntity GetLatest()
    {
      throw new NotImplementedException();
    }
  }
}
