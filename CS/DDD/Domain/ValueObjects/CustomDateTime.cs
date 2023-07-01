namespace Domain.ValueObjects
{
  public sealed class CustomDateTime : BaseValueObject
  {
    private static readonly string _format = "yyyy-MM-dd HH:mm:ss";

    internal DateTime Value { get; }

    internal CustomDateTime(DateTime value)
    {
      Value = value;
    }

    public string DisplayValue => Value.ToString(_format);

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
