using System.Collections.ObjectModel;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class LatestWeatherViewModel : BindableBase
  {
    private readonly ILatestWeatherRepository _weather;
    private readonly IAreaRepository _area;
    public DelegateCommand SearchCommand { get; }

    internal LatestWeatherViewModel()
      : this(Factories.CreateLatestWeather(), Factories.CreateArea()) { }

    private LatestWeatherViewModel(ILatestWeatherRepository weather, IAreaRepository area)
    {
      SearchCommand = new DelegateCommand(Search);
      _weather = weather;
      _area = area;
      _selectedZipCode = null;
      _measuredDate = "";
      _temperature = "";
      _condition = "";

      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }
    }

    private ObservableCollection<AreaViewModel> _areas = new();
    public ObservableCollection<AreaViewModel> Areas
    {
      get => _areas;
      set => SetProperty(ref _areas, value);
    }

    private AreaViewModel? _selectedZipCode;
    public AreaViewModel? SelectedZipCode
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
      if (_selectedZipCode != null)
      {
        WeatherEntity? weather = _weather.Search(_selectedZipCode.ZipCode);
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
}
