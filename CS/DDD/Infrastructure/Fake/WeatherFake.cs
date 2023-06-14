using Domain;
using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class WeatherFake : IWeatherRepository
  {
    public WeatherEntity GetLatest()
    {
      try
      {
        string fakeWeatherPath = Shared.FakeWeatherPath ?? throw new Exception("FakeWeatherPath not specified in config file.");
        string[] lines = File.ReadAllLines(fakeWeatherPath);
        string[] value = lines[0].Split(",");
        return new WeatherEntity(value[0], value[1].ToDateTime(), value[2].ToSingle(), value[3]);
      }
      catch
      {
        return new WeatherEntity("20000", "2020-08-10 12:10:10".ToDateTime(), 22.222f, "CLOUDY");
      }
    }
  }
}
