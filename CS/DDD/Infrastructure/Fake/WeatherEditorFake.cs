using Domain.Repositories;

namespace Infrastructure.Fake
{
  internal sealed class WeatherEditorFake : IWeatherEditorRepository
  {
    public void Edit(string? zipCode, DateTime? measuredDate, float? temperature, string? condition) { }
  }
}
