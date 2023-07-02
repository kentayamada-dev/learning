using System.Collections.ObjectModel;
using Domain.Entities;

namespace Domain.Repositories
{
  public interface IWeatherRepository
  {
    ReadOnlyCollection<WeatherListEntity> Gets(int? userId);
    WeatherEntity? GetLatest(string userId, string zipCode);
    void Edit(WeatherEntity weather, string userId);
  }
}
