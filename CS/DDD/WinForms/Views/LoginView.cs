using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class LoginView : BaseView
  {
    private readonly LoginViewModel _model = new();

    internal LoginView()
    {
      InitializeComponent();
      _ = NameTextBox.DataBindings.Add(nameof(NameTextBox.Text), _model, nameof(_model.Name));
      _ = PasswordTextBox.DataBindings.Add(nameof(PasswordTextBox.Text), _model, nameof(_model.Password));
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      try
      {
        _model.Auth();
        using WeatherListView WeatherListView = new();
        _ = WeatherListView.ShowDialog();
      }
      catch (Exception Exception)
      {
        BaseExceptionProc(Exception);
      }
    }
  }
}
