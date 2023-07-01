using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class Password : BaseValueObject
  {
    public string Value { get; }

    internal Password(string value)
    {
      Validator(value);
      Value = value;
    }

    internal static void Validator(string password)
    {
      int minLength = 5;
      int maxLength = 10;
      if (password.Length > maxLength || password.Length < minLength)
      {
        throw new CustomException($"Length of password should be between {minLength} to {maxLength}.", ExceptionKind.Error);
      }
    }

    public string DisplayValue => Value.ToString();

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
