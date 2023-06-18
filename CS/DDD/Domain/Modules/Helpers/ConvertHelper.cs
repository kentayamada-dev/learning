namespace Domain.Modules.Helpers
{
  public static class ConvertHelper
  {
    public static string ToNotNullString(this object value)
    {
      return Convert.ToString(value) ?? "";
    }

    public static DateTime ToDateTime(this object value)
    {
      return Convert.ToDateTime(value);
    }

    public static float ToSingle(this object value)
    {
      return Convert.ToSingle(value);
    }
  }
}
