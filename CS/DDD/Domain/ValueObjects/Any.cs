using Domain.Modules.Helpers;

namespace Domain.ValueObjects
{
  public sealed class Any<T> : BaseValueObject
  {
    public T Value { get; }

    internal Any(T value)
    {
      Value = value;
    }

    public string DisplayValue => Value?.ToNotNullString() ?? "";

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      if (Value != null)
      {
        yield return Value;
      }
    }
  }
}
