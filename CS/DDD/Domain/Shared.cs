using Microsoft.Extensions.Configuration;

namespace Domain
{
  public static class Shared
  {
    private static readonly IConfiguration _configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile(path: "appsettings.json", true, true)
      .Build();

    public static string? UserName { get; set; } = null;
    public static bool IsDebugMode =>
#if DEBUG
      true;
#else
      false;
#endif
    public static bool IsFake => _configuration["IsFake"] == "True" && IsDebugMode;
  }
}
