using System.ComponentModel;
using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal class WeathersListViewModel
  {
    private readonly IWeatherRepository _weather;
    public BindingList<WeatherListViewModel> Weathers { get; } = new();

    internal WeathersListViewModel()
      : this(Factories.CreateWeather()) { }

    internal WeathersListViewModel(IWeatherRepository weather)
    {
      _weather = weather;

      foreach (WeatherListEntity entity in _weather.Gets(Shared.User?.ID.Value))
      {
        Weathers.Add(new WeatherListViewModel(entity));
      }
    }
  }
}
