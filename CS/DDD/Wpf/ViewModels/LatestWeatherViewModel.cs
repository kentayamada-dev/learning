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
    public ObservableCollection<AreaViewModel> Areas { get; } = new();

    private LatestWeatherViewModel()
      : this(Factories.CreateLatestWeather(), Factories.CreateArea()) { }

    private LatestWeatherViewModel(ILatestWeatherRepository weather, IAreaRepository area)
    {
      _weather = weather;
      _area = area;

      foreach (AreaEntity areaData in _area.Gets())
      {
        Areas.Add(new(areaData));
      }
    }

    private DelegateCommand? _searchCommand;
    public DelegateCommand SearchCommand => _searchCommand ??= new DelegateCommand(Search);

    private AreaViewModel? _selectedArea;
    public AreaViewModel? SelectedArea
    {
      get => _selectedArea;
      set => SetProperty(ref _selectedArea, value);
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

    internal void Search()
    {
      if (_selectedArea != null)
      {
        WeatherEntity? weather = _weather.Search(_selectedArea.ZipCode);
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
