using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinForms.ViewModels
{
  internal abstract class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler? PropertyChanged;

    private protected void SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
      if (!Equals(field, value))
      {
        field = value;
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    private protected virtual DateTime GetDateTime()
    {
      return DateTime.Now;
    }
  }
}
