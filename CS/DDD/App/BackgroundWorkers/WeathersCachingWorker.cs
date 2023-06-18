using Domain.StaticValues;
using Infrastructure;

namespace App.BackgroundWorkers
{
  internal static class WeathersCachingWorker
  {
    private static readonly System.Threading.Timer _timer;
    private static bool _isCreatingCache = false;
    public static bool IsWeathersCachingWorkerRunning;

    static WeathersCachingWorker()
    {
      _timer = new System.Threading.Timer(Callback);
    }

    internal static void Start()
    {
      IsWeathersCachingWorkerRunning = true;
      _ = _timer.Change(0, 30000);
    }

    internal static void Stop()
    {
      IsWeathersCachingWorkerRunning = false;
      _ = _timer.Change(Timeout.Infinite, Timeout.Infinite);
    }

    private static void Callback(object? obj)
    {
      if (_isCreatingCache)
      {
        return;
      }
      try
      {
        _isCreatingCache = true;
        Weathers.CreateWeathersCache(Factories.CreateWeather());
      }
      finally
      {
        _isCreatingCache = false;
      }
    }
  }
}
