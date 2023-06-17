namespace Domain.ValueObjects
{
  public sealed class StateAbbr : BaseValueObject
  {
    public string Value { get; }

    public StateAbbr(string value)
    {
      Value = value;
    }

    private protected override IEnumerable<object> GetEqualityComponents()
    {
      yield return Value;
    }
  }
}
