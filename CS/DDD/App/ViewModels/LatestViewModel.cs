using Domain.Entities;
using Domain.Repositories;
using Infrastructure;

namespace App.ViewModels
{
  public sealed class LatestViewModel : BaseViewModel
  {
    private readonly WeatherRepository _weatherRepository;

    public LatestViewModel()
      : this(Factories.CreateWeather()) { }

    public LatestViewModel(IWeatherRepository weatherRepository)
    {
      _weatherRepository = new WeatherRepository(weatherRepository);
    }

    private string _zipCode = string.Empty;
    public string ZipCode
    {
      get => _zipCode;
      set => SetProperty(ref _zipCode, value);
    }

    private string _measuredDate = string.Empty;
    public string MeasuredDate
    {
      get => _measuredDate;
      set => SetProperty(ref _measuredDate, value);
    }

    private string _temperature = string.Empty;
    public string Temperature
    {
      get => _temperature;
      set => SetProperty(ref _temperature, value);
    }

    private string _condition = string.Empty;
    public string Condition
    {
      get => _condition;
      set => SetProperty(ref _condition, value);
    }

    public void Search()
    {
      WeatherEntity _weather = _weatherRepository.GetLatest();
      ZipCode = _weather.ZipCode.Value;
      MeasuredDate = _weather.MeasuredDate.DisplayValue;
      Temperature = _weather.Temperature.DisplayValue;
      Condition = _weather.Condition.DisplayValue;
    }
  }
}
