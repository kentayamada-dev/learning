using System;
using Domain.Entities;

namespace Wpf.ViewModels
{
  internal sealed class WeatherListViewModel
  {
    private readonly WeatherListEntity _entity;

    internal WeatherListViewModel(WeatherListEntity entity)
    {
      _entity = entity;
    }

    public string ZipCode => _entity.ZipCode.DisplayValue;
    public string StateAbbr => _entity.StateAbbr.DisplayValue;
    public string MeasuredDateDisplayValue => _entity.MeasuredDate.DisplayValue;
    public DateTime MeasuredDateValue => _entity.MeasuredDate.Value;
    public string ConditionDisplayValue => _entity.Condition.DisplayValue;
    public string ConditionValue => _entity.Condition.Value;
    public string TemperatureDisplayValue => _entity.Temperature.DisplayValue;
    public float TemperatureValue => _entity.Temperature.Value;
  }
}
