using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Domain
{
  public static class Shared
  {
    private static readonly IConfiguration _configuration = new ConfigurationBuilder()
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json", true, true)
      .Build();
    public static bool IsDebugMode =>
#if DEBUG
      true;
#else
      false;
#endif
    public static string? FakeUserPath => _configuration[nameof(FakeUserPath)];
    public static string? FakeWeathersPath => _configuration[nameof(FakeWeathersPath)];
    public static string? FakeAreasPath => _configuration[nameof(FakeAreasPath)];
    public static string? FakeWeatherPath => _configuration[nameof(FakeWeatherPath)];
    public static bool IsFake => _configuration[nameof(IsFake)] == "True" && IsDebugMode;
    public static int CacheIntervalSec => 30;
    public static UserEntity? User { get; set; } = null;
  }
}
