using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class SignupView : BaseView
  {
    private readonly SignupViewModel _model = new();

    internal SignupView()
    {
      InitializeComponent();
      _ = NameTextBox.DataBindings.Add(nameof(NameTextBox.Text), _model, nameof(_model.Name));
      _ = PasswordTextBox.DataBindings.Add(nameof(PasswordTextBox.Text), _model, nameof(_model.Password));
    }

    private void SignupButton_Click(object sender, EventArgs e)
    {
      try
      {
        _model.Signup();
        using LatestWeatherView LatestWeatherView = new();
        _ = LatestWeatherView.ShowDialog();
      }
      catch (Exception Exception)
      {
        BaseExceptionProc(Exception);
      }
    }
  }
}
