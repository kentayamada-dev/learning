using Prism.Mvvm;

namespace Wpf.ViewModels
{
  internal class MainWindowViewModel : BindableBase
  {
    private string _title = "Main Window";
    private MainWindowViewModel()
    {
    }

    public string Title
    {
      get => _title;
      set => SetProperty(ref _title, value);
    }
  }
}