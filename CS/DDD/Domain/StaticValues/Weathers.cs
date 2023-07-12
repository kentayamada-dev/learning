using System.Collections;
using Domain.Entities;
using Domain.Repositories;

namespace Domain.StaticValues
{
  public static class Weathers
  {
    private static readonly List<WeatherEntity> _weathers = new();

    public static void CreateWeathersCache(IWeatherRepository weather)
    {
      lock (((ICollection)_weathers).SyncRoot)
      {
        _weathers.Clear();
        _weathers.AddRange(weather.GetLatestList(Shared.CurrentUser.ID.DisplayValue));
      }
    }

    public static WeatherEntity? GetCashedWeathers(string zipCode)
    {
      lock (((ICollection)_weathers).SyncRoot)
      {
        return _weathers.Find(x => x.ZipCode.Value == zipCode);
      }
    }
  }
}
