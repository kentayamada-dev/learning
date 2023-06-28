using Domain;
using Domain.Exceptions;
using log4net;

namespace WinForms.Views
{
  internal partial class BaseView : Form
  {
    private static readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()!.DeclaringType);

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
      MessageBoxIcon icon = MessageBoxIcon.None;
      string caption = "";
      if (exception is CustomException CustomException)
      {
        if (CustomException.Kind == CustomException.ExceptionKind.Information)
        {
          icon = MessageBoxIcon.Information;
          caption = "Information";
          _logger.Info(exception.Message, exception);
        }
        else if (CustomException.Kind == CustomException.ExceptionKind.Warning)
        {
          icon = MessageBoxIcon.Warning;
          caption = "Warning";
          _logger.Warn(exception.Message, exception);
        }
        else
        {
          icon = MessageBoxIcon.Error;
          caption = "Error";
          _logger.Error(exception.Message, exception);
        }
      }
      _ = MessageBox.Show(exception.Message, caption, MessageBoxButtons.OK, icon);
    }
  }
}
