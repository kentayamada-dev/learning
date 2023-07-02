using Domain.Entities;

namespace Domain.Repositories
{
  public interface ILatestWeatherRepository
  {
    WeatherEntity? Search(string zipCode);
  }
}
