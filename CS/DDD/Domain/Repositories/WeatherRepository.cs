﻿using Domain.Entities;

namespace Domain.Repositories
{
  public sealed class WeatherRepository
  {
    private readonly IWeatherRepository _repository;

    public WeatherRepository(IWeatherRepository repositor)
    {
      _repository = repositor;
    }

    public WeatherEntity? GetLatest(string zipCode)
    {
      WeatherEntity? val1 = _repository.GetLatest(zipCode);
      WeatherEntity? val2 = _repository.GetLatest(zipCode);
      WeatherEntity? val3 = _repository.GetLatest(zipCode);

      if (val1 == null || val2 == null || val3 == null)
      {
        return null;
      }

      float ave = (val1.Temperature.Value + val2.Temperature.Value + val3.Temperature.Value) / 3;

      return new WeatherEntity(val1.ZipCode.Value, val1.MeasuredDate.Value, ave, val1.Condition.Value);
    }
  }
}
