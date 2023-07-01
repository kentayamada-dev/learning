using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class WeatherFake : IWeatherRepository
  {
    public ReadOnlyCollection<WeatherListEntity> Gets(int? userId)
    {
      ReadOnlyCollection<WeatherListEntity> weathers = new List<WeatherListEntity>()
      {
        new WeatherListEntity("10001", "2020-08-11 13:20:50".ToDateTime(), 20f, "UNKNOWN", "NY"),
        new WeatherListEntity("20002", "2019-09-11 14:30:40".ToDateTime(), 19.351f, "CLOUDY", "FL"),
        new WeatherListEntity("30003", "2018-10-11 15:40:30".ToDateTime(), 12.31f, "RAINY", "AS"),
        new WeatherListEntity("40004", "2017-11-11 16:50:20".ToDateTime(), 12.1f, "SUNNY", "NE")
      }.AsReadOnly();
      return weathers;
    }
  }
}
