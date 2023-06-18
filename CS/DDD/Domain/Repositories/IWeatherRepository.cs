using System.Collections.ObjectModel;
using Domain.Entities;

namespace Domain.Repositories
{
  public interface IWeatherRepository
  {
    WeatherEntity? GetLatest(string zipCode);
    ReadOnlyCollection<WeatherEntity> GetLatestList();
    ReadOnlyCollection<WeatherListEntity> GetData();
    void Edit(WeatherEntity weather);
  }
}
