namespace Domain.Entities
{
  public sealed class WeatherEntity
  {
    public string ZipCode { get; }
    public DateTime MeasuredDate { get; }
    public float Temperature { get; }
    public string Condition { get; }

    public WeatherEntity(string zipCode, DateTime measuredDate, float temperature, string condition)
    {
      ZipCode = zipCode;
      MeasuredDate = measuredDate;
      Temperature = temperature;
      Condition = condition;
    }
  }
}
