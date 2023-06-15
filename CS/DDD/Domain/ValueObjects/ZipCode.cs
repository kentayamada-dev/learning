namespace Domain.ValueObjects
{
  public sealed class ZipCode : BaseValueObject
  {
    public string Value { get; }

    public ZipCode(string value)
    {
      Value = value;
    }

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
