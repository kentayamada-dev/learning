using System.Configuration;

namespace Domain
{
  public static class Shared
  {
    public static bool IsFake => ConfigurationManager.AppSettings["IsFake"] == "1";
    public static string? FakeWeathersPath => ConfigurationManager.AppSettings["FakeWeathersPath"];
    public static string? FakeAreasPath => ConfigurationManager.AppSettings["FakeAreasPath"];
    public static string LoginID { get; set; } = "XXXXXX";
    public static bool IsDebugMode =>
#if DEBUG
    true;
#else
   false;
#endif
  }
}
