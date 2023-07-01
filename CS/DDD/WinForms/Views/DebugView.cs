using Domain;

namespace WinForms.Views
{
  internal partial class DebugView : Form
  {
    internal DebugView()
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
      using SigninView SigninView = new();
      _ = SigninView.ShowDialog();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
