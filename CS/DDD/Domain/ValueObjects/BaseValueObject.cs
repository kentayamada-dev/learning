namespace Domain.ValueObjects
{
  public abstract class BaseValueObject
  {
    private protected abstract IEnumerable<object> GetEqualityComponents();

    public override int GetHashCode()
    {
      return GetEqualityComponents().Select(x => x != null ? x.GetHashCode() : 0).Aggregate((x, y) => x ^ (y * 2));
    }

    public override bool Equals(object? obj)
    {
      if (obj == null || obj.GetType() != GetType())
      {
        return false;
      }

      BaseValueObject other = (BaseValueObject)obj;

      return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    private static bool EqualOperator(BaseValueObject left, BaseValueObject right)
    {
      return !(left is null ^ right is null) && (ReferenceEquals(left, right) || (left is not null && left.Equals(right)));
    }

    private static bool NotEqualOperator(BaseValueObject left, BaseValueObject right)
    {
      return !EqualOperator(left, right);
    }

    public static bool operator ==(BaseValueObject one, BaseValueObject two)
    {
      return EqualOperator(one, two);
    }

    public static bool operator !=(BaseValueObject one, BaseValueObject two)
    {
      return NotEqualOperator(one, two);
    }
  }
}
