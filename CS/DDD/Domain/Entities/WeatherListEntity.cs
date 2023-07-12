using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class WeatherListEntity
  {
    public ZipCode ZipCode { get; }
    public CustomDateTime MeasuredDate { get; }
    public Temperature Temperature { get; }
    public Condition Condition { get; }
    public StateAbbr StateAbbr { get; }

    public WeatherListEntity(string? zipCode, DateTime? measuredDate, float? temperature, string? condition, string? stateAbbr)
    {
      ZipCode = new(zipCode);
      MeasuredDate = new(measuredDate, $"{MeasuredDate}");
      Temperature = new(temperature);
      Condition = new(condition);
      StateAbbr = new(stateAbbr);
    }
  }
}
