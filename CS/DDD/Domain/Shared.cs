using System.Configuration;

namespace Domain
{
  public static class Shared
  {
    public static bool IsFake { get; } = ConfigurationManager.AppSettings["IsFake"] == "1";
    public static string? FakeWeatherPath { get; } = ConfigurationManager.AppSettings["FakeWeatherPath"];
    public static string LoginID { get; set; } = string.Empty;
  }
}
