using Domain.Entities;

namespace Domain.Repositories
{
  public interface IWeatherRepository
  {
    WeatherEntity? GetLatest(string zipCode);
  }
}
