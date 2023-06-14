using Domain.Entities;
using Domain.Helpers;
using Domain.Repositories;

namespace App.ViewModels
{
  public sealed class LatestViewModel
  {
    private readonly IWeatherRepository _weatherRepository;
    private WeatherEntity? _weather;

    public LatestViewModel(IWeatherRepository weatherRepository)
    {
      _weatherRepository = weatherRepository;
    }

    public string ZipCode => _weather == null ? "" : _weather.ZipCode.ToNotNullString();
    public string MeasuredDate => _weather == null ? "" : _weather.MeasuredDate.ToString("yyyy-MM-dd HH:mm:ss");
    public string Temperature => _weather == null ? "" : Math.Round(_weather.Temperature, 2).ToString() + "℃";
    public string Condition => _weather == null ? "" : "Sunny";

    public void Search()
    {
      _weather = _weatherRepository.GetLatest();
    }
  }
}
