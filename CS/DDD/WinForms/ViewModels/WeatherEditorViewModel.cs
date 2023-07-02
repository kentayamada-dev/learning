using System.ComponentModel;
using Domain.Entities;
using Domain.Repositories;
using Domain.ValueObjects;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class WeatherEditorViewModel : BaseViewModel
  {
    private readonly IWeatherEditorRepository _weather;
    private readonly IAreaRepository _area;
    public BindingList<AreaViewModel> Areas { get; } = new();
    public BindingList<ConditionViewModel> Conditions { get; } = new();

    internal WeatherEditorViewModel()
      : this(Factories.CreateWeatherEditor(), Factories.CreateArea()) { }

    private WeatherEditorViewModel(IWeatherEditorRepository weather, IAreaRepository area)
    {
      _weather = weather;
      _area = area;
      MeasuredDate = GetDateTime();
      SelectedCondition = Condition.Sunny.Value;
      TemperatureValue = 0f;
      SelectedZipCode = "";
      TemperatureUnit = Temperature.Unit;

      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }

      foreach (Condition conditionData in Condition.ToList())
      {
        Conditions.Add(new(conditionData));
      }
    }

    public string SelectedZipCode { get; set; }
    public DateTime MeasuredDate { get; set; }
    public string SelectedCondition { get; set; }
    public float TemperatureValue { get; set; }
    public string TemperatureUnit { get; }

    internal void Save()
    {
      _weather.Edit(SelectedZipCode, MeasuredDate, TemperatureValue, SelectedCondition);
    }
  }
}
