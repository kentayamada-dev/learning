using System.Text.RegularExpressions;
using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed partial class ZipCode : BaseValueObject
  {
    public string Value { get; }

    internal ZipCode(string value)
    {
      if (!ValidZipCodeRegex().IsMatch(value))
      {
        throw new CustomException("ZipCode is invalid format", ExceptionKind.Error);
      }
      Value = value;
    }

    public string DisplayValue => Value.ToString();

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }

    [GeneratedRegex("[0-9][0-9][0-9][0-9][0-9]")]
    private static partial Regex ValidZipCodeRegex();
  }
}
