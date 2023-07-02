using System.Collections.ObjectModel;
using Domain.Entities;

namespace Domain.Repositories
{
  public interface IWeatherRepository
  {
    ReadOnlyCollection<WeatherListEntity> Gets(int? userId);
    WeatherEntity? GetLatest(string userId, string zipCode);
    void Edit(string zipCode, DateTime measuredDate, float temperature, string condition, string userId);
  }
}
