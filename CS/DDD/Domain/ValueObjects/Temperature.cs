using Domain.Helpers;

namespace Domain.ValueObjects
{
  public sealed class Temperature : BaseValueObject
  {
    private static readonly string _unit = "℃";
    private static readonly int _decimalPoint = 1;

    public float Value { get; }

    public Temperature(float value)
    {
      Value = value;
    }

    public string DisplayValue => Value.ToRoundedFloatString(_decimalPoint) + _unit;

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
