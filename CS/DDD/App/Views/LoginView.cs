using Domain;

namespace App.Views
{
  internal partial class LoginView : BaseView
  {
    internal LoginView()
    {
      InitializeComponent();
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
      Shared.LoginID = LoginIDTextBox.Text;
      using LatestView f = new();
      _ = f.ShowDialog();
    }
  }
}
