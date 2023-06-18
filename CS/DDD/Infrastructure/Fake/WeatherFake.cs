using System.Collections.ObjectModel;
using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class WeatherFake : IWeatherRepository
  {
    public void Edit(WeatherEntity weather) { }

    public ReadOnlyCollection<WeatherListEntity> GetData()
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

    public WeatherEntity GetLatest(string zipCode)
    {
      try
      {
        string fakeWeathersPath = Shared.FakeWeathersPath ?? throw new Exception("FakeWeathersPath not specified in config file.");
        string[] lines = File.ReadAllLines(fakeWeathersPath);
        string[] value = lines[0].Split(",");
        return new WeatherEntity(value[0], value[1].ToDateTime(), value[2].ToSingle(), value[3]);
      }
      catch (Exception Exception)
      {
        throw new FakeException("Exception Occurred.", Exception);
      }
    }

    public ReadOnlyCollection<WeatherEntity> GetLatestList()
    {
      ReadOnlyCollection<WeatherEntity> weathers = new List<WeatherEntity>()
      {
        new WeatherEntity("10001", "2020-08-11 13:20:50".ToDateTime(), 20f, "UNKNOWN"),
        new WeatherEntity("20002", "2019-09-11 14:30:40".ToDateTime(), 19.351f, "CLOUDY"),
        new WeatherEntity("30003", "2018-10-11 15:40:30".ToDateTime(), 12.31f, "RAINY"),
        new WeatherEntity("40004", "2017-11-11 16:50:20".ToDateTime(), 12.1f, "SUNNY")
      }.AsReadOnly();

      return weathers;
    }
  }
}
