using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class WeatherViewModel : BindableBase
  {
    private WeatherViewModel() { }

    public static string Title => "Weather";
  }
}
