using System.Collections.ObjectModel;
using System.Diagnostics;
using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class WeathersListViewModel : BindableBase
  {
    private readonly IWeatherRepository _weather;

    private WeathersListViewModel()
      : this(Factories.CreateWeather()) { }

    private WeathersListViewModel(IWeatherRepository weather)
    {
      _weather = weather;

      foreach (WeatherListEntity entity in _weather.Gets(Shared.User?.ID.Value))
      {
        Weathers.Add(new(entity));
      }
    }

    private ObservableCollection<WeatherListViewModel> _weathers = new();
    public ObservableCollection<WeatherListViewModel> Weathers
    {
      get => _weathers;
      set => SetProperty(ref _weathers, value);
    }

    private WeatherListViewModel? _selectedWeather;
    public WeatherListViewModel? SelectedWeather
    {
      get => _selectedWeather;
      set => SetProperty(ref _selectedWeather, value);
    }

    private DelegateCommand<WeatherListViewModel>? _editWeatherCommand;
    public DelegateCommand<WeatherListViewModel> EditWeatherCommand =>
_editWeatherCommand ??= new DelegateCommand<WeatherListViewModel>(EditWeather);

    private void EditWeather(WeatherListViewModel weather)
    {
      Debug.Print(weather.MeasuredDate);
    }
  }
}
