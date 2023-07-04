using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class WeatherWindowViewModel : BindableBase
  {
    private string _title = "Weather";
    private WeatherWindowViewModel()
    {
    }

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }
  }
}