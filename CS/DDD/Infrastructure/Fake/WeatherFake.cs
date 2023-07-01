﻿using System.Collections.ObjectModel;
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
      string fakeWeathersPath = Shared.FakeWeathersPath ?? throw new CustomException($"{nameof(Shared.FakeWeathersPath)} not specified in appsettings.json.", CustomException.ExceptionKind.Error);
      List<WeatherListEntity> weathers = new();
      foreach (string line in File.ReadAllLines(fakeWeathersPath))
      {
        string[] value = line.Split(",");
        weathers.Add(new WeatherListEntity(value[0], value[1].ToDateTime(), value[2].ToSingle(), value[3], value[4]));
      }
      return weathers.AsReadOnly();
    }
  }
}