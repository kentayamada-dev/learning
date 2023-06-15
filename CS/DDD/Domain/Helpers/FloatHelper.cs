namespace Domain.Helpers
{
  internal static class FloatHelper
  {
    internal static string ToRoundedFloatString(this float value, int decimalPoint)
    {
      return Convert.ToSingle(Math.Round(value, decimalPoint)).ToString("F" + decimalPoint);
    }
  }
}
