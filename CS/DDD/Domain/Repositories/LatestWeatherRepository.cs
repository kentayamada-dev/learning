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
      UserEntity? currentUser = Shared.User;
      return currentUser != null ? (_weather?.GetLatest(currentUser.ID.DisplayValue, zipCode)) : null;
    }
  }
}
