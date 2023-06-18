using System.ComponentModel;
using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace App.ViewModels
{
  public sealed class ListViewModel : BaseViewModel
  {
    private readonly IWeatherRepository _weather;
    public BindingList<WeatherListViewModel> Weathers { get; } = new();

    public ListViewModel()
      : this(Factories.CreateWeather()) { }

    public ListViewModel(IWeatherRepository weather)
    {
      _weather = weather;

      foreach (WeatherListEntity entity in _weather.GetData())
      {
        Weathers.Add(new WeatherListViewModel(entity));
      }
    }
  }
}
