using Domain;
using Domain.Exceptions;

namespace WinForms.Views
{
  internal partial class BaseView : Form
  {
    private protected BaseView()
    {
      InitializeComponent();
      if (Shared.UserName != null)
      {
        NameLabel.Visible = true;
        NameValueLabel.Visible = true;
        NameValueLabel.Text = Shared.UserName;
      }
    }

    private protected static void BaseExceptionProc(Exception exception)
    {
      //_logger.Error(Ex.Message, Ex);
      MessageBoxIcon icon = MessageBoxIcon.Error;
      string caption = "Error";
      if (exception is CustomException CustomException)
      {
        if (CustomException.Kind == CustomException.ExceptionKind.Information)
        {
          icon = MessageBoxIcon.Information;
          caption = "Information";
        }
        else if (CustomException.Kind == CustomException.ExceptionKind.Warning)
        {
          icon = MessageBoxIcon.Warning;
          caption = "Warning";
        }
      }
      _ = MessageBox.Show(exception.Message, caption, MessageBoxButtons.OK, icon);
    }
  }
}
