using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class WeatherViewModel : BindableBase
  {
    private string _title = "Weather";
    private WeatherViewModel()
    {
    }

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }
  }
}