using Domain.Helpers;

namespace Domain.ValueObjects
{
  public sealed class Temperature : BaseValueObject
  {
    public static readonly string Unit = "℃";
    private static readonly int _decimalPoint = 1;

    public float Value { get; }

    public Temperature(float value)
    {
      Value = value;
    }

    public string DisplayValue => Value.ToRoundedFloatString(_decimalPoint) + Unit;

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
