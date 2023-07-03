using System.ComponentModel;
using Domain.Entities;
using Domain.Modules.Helpers;
using Domain.Repositories;
using Domain.StaticValues;
using Infrastructure;
using WinForms.BackgroundWorkers;

namespace WinForms.ViewModels
{
  internal sealed class LatestWeatherViewModel : BaseViewModel
  {
    private readonly ILatestWeatherRepository _weather;
    private readonly IAreaRepository _area;
    public BindingList<AreaViewModel> Areas { get; } = new();

    internal LatestWeatherViewModel()
      : this(Factories.CreateLatestWeather(), Factories.CreateArea()) { }

    private LatestWeatherViewModel(ILatestWeatherRepository weather, IAreaRepository area)
    {
      _weather = weather;
      _area = area;
      _selectedZipCode = "";
      _measuredDate = "";
      _temperature = "";
      _condition = "";

      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }
    }

    private string _selectedZipCode;
    public string SelectedZipCode
    {
      get => _selectedZipCode;
      set => SetProperty(ref _selectedZipCode, value);
    }

    private string _measuredDate;
    public string MeasuredDate
    {
      get => _measuredDate;
      set => SetProperty(ref _measuredDate, value);
    }

    private string _temperature;
    public string Temperature
    {
      get => _temperature;
      set => SetProperty(ref _temperature, value);
    }

    private string _condition;
    public string Condition
    {
      get => _condition;
      set => SetProperty(ref _condition, value);
    }

    internal void Search()
    {
      WeatherEntity? weather = WeathersCachingWorker.IsWeathersCachingWorkerRunning
        ? Weathers.GetCashedWeathers(_selectedZipCode.ToNotNullString())
        : _weather.Search(_selectedZipCode.ToNotNullString());
      if (weather == null)
      {
        MeasuredDate = "";
        Temperature = "";
        Condition = "";
      }
      else
      {
        MeasuredDate = weather.MeasuredDate.DisplayValue;
        Temperature = weather.Temperature.DisplayValue;
        Condition = weather.Condition.DisplayValue;
      }
    }
  }
}
