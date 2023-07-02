using Domain;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class LatestWeatherFake : ILatestWeatherRepository
  {
    public WeatherEntity? Search(string zipCode)
    {
      string fakeWeatherPath =
        Shared.FakeWeatherPath
        ?? throw new CustomException($"{nameof(Shared.FakeWeatherPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      string[] lines = File.ReadAllLines(fakeWeatherPath);
      string[] value = lines[0].Split(",");

      return new(value[0].ToNotNullString(), value[1].ToDateTime(), value[2].ToSingle(), value[4].ToNotNullString());
    }
  }
}
