using Domain.Exceptions;
using Domain.Modules.Helpers;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class Temperature : BaseValueObject
  {
    public static readonly string Unit = "℃";
    private static readonly int _decimalPoint = 1;

    public float Value { get; }

    internal Temperature(float? value)
    {
      Value = value ?? throw new CustomException("Temperature is Invalid format", ExceptionKind.Error);
    }

    public string DisplayValue => Value.ToRoundedFloatString(_decimalPoint) + Unit;

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
