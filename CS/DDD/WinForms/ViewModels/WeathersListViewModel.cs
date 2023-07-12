using System.ComponentModel;
using Domain;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace WinForms.ViewModels
{
  internal sealed class WeathersListViewModel
  {
    private readonly IWeatherRepository _weather;
    public BindingList<WeatherListViewModel> Weathers { get; } = new();

    internal WeathersListViewModel()
      : this(Factories.CreateWeather()) { }

    private WeathersListViewModel(IWeatherRepository weather)
    {
      _weather = weather;

      foreach (WeatherListEntity entity in _weather.Gets(Shared.CurrentUser.ID.Value))
      {
        Weathers.Add(new(entity));
      }
    }
  }
}
