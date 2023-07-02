using WinForms.ViewModels;

namespace WinForms.Views
{
  internal partial class SigninView : BaseView
  {
    private readonly SigninViewModel _model = new();

    internal SigninView()
    {
      InitializeComponent();
      _ = NameTextBox.DataBindings.Add(nameof(NameTextBox.Text), _model, nameof(_model.Name));
      _ = PasswordTextBox.DataBindings.Add(nameof(PasswordTextBox.Text), _model, nameof(_model.Password));
    }

    private void SigninButton_Click(object sender, EventArgs e)
    {
      try
      {
        _model.Signin();
        using LatestWeatherView LatestWeatherView = new();
        _ = LatestWeatherView.ShowDialog();
      }
      catch (Exception Exception)
      {
        BaseExceptionProc(Exception);
      }
    }

    private void SignupButton_Click(object sender, EventArgs e)
    {
      using SignupView SignupView = new();
      _ = SignupView.ShowDialog();
    }
  }
}
