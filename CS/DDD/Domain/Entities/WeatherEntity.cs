using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class WeatherEntity
  {
    public ZipCode ZipCode { get; }
    public CustomDateTime MeasuredDate { get; }
    public Temperature Temperature { get; }
    public Condition Condition { get; }

    public WeatherEntity(string? zipCode, DateTime? measuredDate, float? temperature, string? condition)
    {
      ZipCode = new(zipCode);
      MeasuredDate = new(measuredDate, $"{MeasuredDate}");
      Temperature = new(temperature);
      Condition = new(condition);
    }
  }
}
