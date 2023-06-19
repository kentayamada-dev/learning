using System.ComponentModel;
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Infrastructure;

namespace App.ViewModels
{
  public sealed class EditViewModel : BaseViewModel
  {
    private readonly WeatherRepository _weather;
    private readonly IAreaRepository _area;
    public BindingList<AreaViewModel> Areas { get; } = new();
    public BindingList<ConditionViewModel> Conditions { get; } = new();

    public EditViewModel()
      : this(Factories.CreateWeather(), Factories.CreateArea()) { }

    public EditViewModel(IWeatherRepository weather, IAreaRepository area)
    {
      _weather = new WeatherRepository(weather);
      _area = area;
      MeasuredDate = GetDateTime();
      SelectedCondition = Condition.Sunny.Value;
      TemperatureValue = 0f;
      SelectedZipCode = "";
      TemperatureUnit = Temperature.Unit;

      foreach (AreaEntity areaData in _area.GetData())
      {
        Areas.Add(new AreaViewModel(areaData));
      }

      foreach (Condition conditionData in Condition.ToList())
      {
        Conditions.Add(new ConditionViewModel(conditionData));
      }
    }

    public string SelectedZipCode { get; set; }
    public DateTime MeasuredDate { get; set; }
    public string SelectedCondition { get; set; }
    public float TemperatureValue { get; set; }
    public string TemperatureUnit { get; }

    public void Save()
    {
      _weather.Edit(SelectedZipCode, MeasuredDate, TemperatureValue, SelectedCondition);
    }
  }
}
