namespace Domain.Modules.Helpers
{
  public static class FloatHelper
  {
    public static string ToRoundedFloatString(this float value, int decimalPoint)
    {
      return Convert.ToSingle(Math.Round(value, decimalPoint)).ToString("F" + decimalPoint);
    }
  }
}
