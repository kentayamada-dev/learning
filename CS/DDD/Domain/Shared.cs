using Microsoft.Extensions.Configuration;

namespace Domain
{
  public static class Shared
  {
    private static readonly IConfiguration _configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile(path: "appsettings.json")
      .Build();

    public static string? UserName { get; set; } = null;
    public static bool IsFake => _configuration["IsFake"] == "True";
    public static bool IsDebugMode =>
#if DEBUG
      true;
#else
      false;
#endif
  }
}
