using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class Name : BaseValueObject
  {
    public string Value { get; }

    internal Name(string value)
    {
      Validator(value);
      Value = value;
    }

    internal static void Validator(string name)
    {
      int minLength = 5;
      int maxLength = 10;
      if (name.Length > maxLength || name.Length < minLength)
      {
        throw new CustomException($"Length of name should be between {minLength} to {maxLength}.", ExceptionKind.Error);
      }
    }

    public string DisplayValue => Value.ToString();

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
