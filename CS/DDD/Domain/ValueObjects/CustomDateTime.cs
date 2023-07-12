using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class CustomDateTime : BaseValueObject
  {
    private static readonly string _format = "yyyy-MM-dd HH:mm:ss";

    public DateTime Value { get; }

    internal CustomDateTime(DateTime? value, string propName)
    {
      Value = value ?? throw new CustomException($"{propName} is Invalid format", ExceptionKind.Error);
    }

    public string DisplayValue => Value.ToString(_format);

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
