using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class WeatherFake : IWeatherRepository
  {
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
  }
}
