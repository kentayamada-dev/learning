using System.Collections.ObjectModel;
using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class Condition : BaseValueObject
  {
    private static readonly string[] _conditions = new string[] { "SUNNY", "CLOUDY", "RAINY", "UNKNOWN" };
    public static readonly Condition Sunny = new(_conditions[0]);
    public static readonly Condition Cloudy = new(_conditions[1]);
    public static readonly Condition Rainy = new(_conditions[2]);
    public static readonly Condition Unknown = new(_conditions[3]);

    public string Value { get; }

    internal Condition(string value)
    {
      if (!_conditions.Contains(value))
      {
        throw new CustomException(
          $"Condition should be one of {nameof(Sunny)}, {nameof(Cloudy)}, {nameof(Rainy)} or {nameof(Unknown)}.",
          ExceptionKind.Error
        );
      }
      Value = value;
    }

    public string DisplayValue =>
      this == Sunny
        ? nameof(Sunny)
        : this == Cloudy
          ? nameof(Cloudy)
          : this == Rainy
            ? nameof(Rainy)
            : nameof(Unknown);

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
