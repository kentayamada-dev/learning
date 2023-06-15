using System.Collections.ObjectModel;

namespace Domain.ValueObjects
{
  public sealed class Condition : BaseValueObject
  {
    public static readonly Condition Sunny = new("SUNNY");
    public static readonly Condition Cloudy = new("CLOUDY");
    public static readonly Condition Rainy = new("RAINY");
    public static readonly Condition Unknown = new("UNKNOWN");

    public string Value { get; }

    public Condition(string value)
    {
      Value = value;
    }

    public string DisplayValue =>
      this == Sunny
        ? "Sunny"
        : this == Cloudy
          ? "Cloudy"
          : this == Rainy
            ? "Rainy"
            : "Unknown";

    public static ReadOnlyCollection<Condition> ToList()
    {
      return new List<Condition> { Sunny, Cloudy, Rainy, Unknown }.AsReadOnly();
    }

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
