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
    public ReadOnlyCollection<WeatherListEntity> Gets(int? userId)
    {
      string fakeWeathersPath =
        Shared.FakeWeathersPath
        ?? throw new CustomException($"{nameof(Shared.FakeWeathersPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      List<WeatherListEntity> weathers = new();
      foreach (string line in File.ReadAllLines(fakeWeathersPath))
      {
        string[] value = line.Split(",");
        weathers.Add(new WeatherListEntity(value[0], value[1].ToDateTime(), value[2].ToSingle(), value[3], value[4]));
      }
      return weathers.AsReadOnly();
    }

    public WeatherEntity? GetLatest(string userId, string zipCode)
    {
      string fakeWeatherPath =
        Shared.FakeWeatherPath
        ?? throw new CustomException($"{nameof(Shared.FakeWeatherPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      string[] lines = File.ReadAllLines(fakeWeatherPath);
      string[] value = lines[0].Split(",");

      return new(value[0].ToNotNullString(), value[1].ToDateTime(), value[2].ToSingle(), value[3].ToNotNullString());
    }

    public void Edit(string zipCode, DateTime measuredDate, float temperature, string condition, string userId) { }
  }
}
