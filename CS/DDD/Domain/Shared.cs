namespace Domain
{
  public static class Shared
  {
    public static string? UserName { get; set; } = null;
    public static bool IsFake => false;
    public static bool IsDebugMode =>
#if DEBUG
      true;
#else
      false;
#endif
  }
}
