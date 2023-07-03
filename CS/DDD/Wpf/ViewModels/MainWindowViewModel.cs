using Prism.Mvvm;

namespace Wpf.ViewModels
{
  public class MainWindowViewModel : BindableBase
  {
    private string _title = "Main Window";
    public MainWindowViewModel()
    {
    }

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }
  }
}