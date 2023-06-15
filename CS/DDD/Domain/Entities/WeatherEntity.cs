using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class WeatherEntity
  {
    public ZipCode ZipCode { get; }
    public MeasuredDate MeasuredDate { get; }
    public Temperature Temperature { get; }
    public Condition Condition { get; }

    public WeatherEntity(string zipCode, DateTime measuredDate, float temperature, string condition)
    {
      ZipCode = new ZipCode(zipCode);
      MeasuredDate = new MeasuredDate(measuredDate);
      Temperature = new Temperature(temperature);
      Condition = new Condition(condition);
    }
  }
}
