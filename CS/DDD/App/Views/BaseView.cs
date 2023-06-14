using Domain;

namespace App.Views
{
  internal partial class BaseView : Form
  {
    internal BaseView()
    {
      InitializeComponent();
#if DEBUG
      BackgroundImage = Properties.Resources.debug;
      BackgroundImageLayout = ImageLayout.Center;
#endif
      LoginIDLabel.Text = Shared.LoginID;
    }
  }
}
