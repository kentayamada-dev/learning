using System.ComponentModel;
using App.BackgroundWorkers;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Modules.Helpers;
using Domain.Repositories;
using Domain.StaticValues;
using Infrastructure;

namespace App.ViewModels
{
  public sealed class LatestViewModel : BaseViewModel
  {
    private readonly WeatherRepository _weather;
    private readonly IAreaRepository _area;
    public BindingList<AreaViewModel> Areas { get; } = new();

    public LatestViewModel()
      : this(Factories.CreateWeather(), Factories.CreateArea()) { }

    public LatestViewModel(IWeatherRepository weather, IAreaRepository area)
    {
      _weather = new WeatherRepository(weather);
      _area = area;

      foreach (AreaEntity areaData in _area.GetData())
      {
        Areas.Add(new AreaViewModel(areaData));
      }
    }

    private string _selectedZipCode = "";
    public string SelectedZipCode
    {
      get => _selectedZipCode;
      set => SetProperty(ref _selectedZipCode, value);
    }

    private string _measuredDate = "";
    public string MeasuredDate
    {
      get => _measuredDate;
      set => SetProperty(ref _measuredDate, value);
    }

    private string _temperature = "";
    public string Temperature
    {
      get => _temperature;
      set => SetProperty(ref _temperature, value);
    }

    private string _condition = "";
    public string Condition
    {
      get => _condition;
      set => SetProperty(ref _condition, value);
    }

    public void Search(bool isCachedSearch)
    {
      if (_selectedZipCode == "")
      {
        Guard.IsStringEmpty(SelectedZipCode, "Please Select Area.");
      }
      else
      {
        WeatherEntity? weather;
        if (isCachedSearch)
        {
          if (!WeathersCachingWorker.IsWeathersCachingWorkerRunning)
          {
            WeathersCachingWorker.Start();
          }

          weather = Weathers.GetCashedWeathers(_selectedZipCode.ToNotNullString());
        }
        else
        {
          if (WeathersCachingWorker.IsWeathersCachingWorkerRunning)
          {
            WeathersCachingWorker.Stop();
          }

          weather = _weather.GetLatest(_selectedZipCode.ToNotNullString());
        }
        if (weather == null)
        {
          MeasuredDate = "";
          Temperature = "";
          Condition = "";
          throw new DataNotExistsException();
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
}
