using Domain;

namespace App.Views
{
  internal partial class InfoView : Form
  {
    internal InfoView()
    {
      InitializeComponent();
      if (Shared.IsFake)
      {
        FakeDataModeCheckBox.Checked = true;
      }

      if (Shared.IsDebugMode)
      {
        DebugModeCheckBox.Checked = true;
      }
    }

    private void ProceedButton_Click(object sender, EventArgs e)
    {
      using LoginView LoginView = new();
      _ = LoginView.ShowDialog();
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
