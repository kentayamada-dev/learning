namespace Domain.Repositories
{
  public sealed class WeatherEditorRepository : IWeatherEditorRepository
  {
    private readonly IWeatherRepository _weather;

    public WeatherEditorRepository(IWeatherRepository weather)
    {
      _weather = weather;
    }

    public void Edit(string? zipCode, DateTime? measuredDate, float? temperature, string? condition)
    {
      _weather.Edit(new(zipCode, measuredDate, temperature, condition), Shared.CurrentUser.ID.DisplayValue);
    }
  }
}
