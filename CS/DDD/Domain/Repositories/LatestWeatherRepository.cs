using Domain.Entities;

namespace Domain.Repositories
{
  public sealed class LatestWeatherRepository : ILatestWeatherRepository
  {
    private readonly IWeatherRepository _weather;

    public LatestWeatherRepository(IWeatherRepository weather)
    {
      _weather = weather;
    }

    public WeatherEntity? Search(string zipCode)
    {
      return _weather.GetLatest(Shared.CurrentUser.ID.DisplayValue, zipCode);
    }
  }
}
