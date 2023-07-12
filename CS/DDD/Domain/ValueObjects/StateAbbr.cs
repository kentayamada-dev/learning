using System.Text.RegularExpressions;
using Domain.Exceptions;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed partial class StateAbbr : BaseValueObject
  {
    public string Value { get; }

    internal StateAbbr(string? value)
    {
      if (value == null || !StateAbbrRegex().IsMatch(value))
      {
        throw new CustomException("StateAbbr is invalid format", ExceptionKind.Error);
      }
      Value = value;
    }

    public string DisplayValue => Value.ToString();

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }

    [GeneratedRegex("[A-Z][A-Z]")]
    private static partial Regex StateAbbrRegex();
  }
}
