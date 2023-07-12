using Domain.Exceptions;
using Domain.Modules.Helpers;
using static Domain.Exceptions.CustomException;

namespace Domain.ValueObjects
{
  public sealed class ID : BaseValueObject
  {
    public int Value { get; }

    internal ID(int? value)
    {
      Value = value ?? throw new CustomException("ID is Invalid format", ExceptionKind.Error);
    }

    public string DisplayValue => Value.ToNotNullString() ?? "";

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
