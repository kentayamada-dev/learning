namespace Domain.ValueObjects
{
  public sealed class MeasuredDate : BaseValueObject
  {
    private static readonly string _format = "yyyy-MM-dd HH:mm:ss";

    public DateTime Value { get; }

    public MeasuredDate(DateTime value)
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
