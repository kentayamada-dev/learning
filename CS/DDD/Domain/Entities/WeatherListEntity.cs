using Domain.ValueObjects;

namespace Domain.Entities
{
  public sealed class WeatherListEntity
  {
    public ZipCode ZipCode { get; }
    public MeasuredDate MeasuredDate { get; }
    public Temperature Temperature { get; }
    public Condition Condition { get; }
    public StateAbbr StateAbbr { get; }

    public WeatherListEntity(string zipCode, DateTime measuredDate, float temperature, string condition, string stateAbbr)
    {
      ZipCode = new ZipCode(zipCode);
      MeasuredDate = new MeasuredDate(measuredDate);
      Temperature = new Temperature(temperature);
      Condition = new Condition(condition);
      StateAbbr = new StateAbbr(stateAbbr);
    }
  }
}
