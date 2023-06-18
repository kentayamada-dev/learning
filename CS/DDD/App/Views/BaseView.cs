using System.Reflection;
using Domain;
using Domain.Exceptions;
using log4net;

namespace App.Views
{
  internal partial class BaseView : Form
  {
    private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod()!.DeclaringType);

    private protected BaseView()
    {
      InitializeComponent();
      LoginIDLabel.Text = Shared.LoginID;
    }

    private protected static void BaseExceptionProc(Exception Ex)
    {
      _logger.Error(Ex.Message, Ex);
      MessageBoxIcon icon = MessageBoxIcon.Error;
      string caption = "Error";
      if (Ex is BaseException baseException)
      {
        if (baseException.Kind == BaseException.ExceptionKind.Info)
        {
          icon = MessageBoxIcon.Information;
          caption = "Information";
        }
        else if (baseException.Kind == BaseException.ExceptionKind.Warning)
        {
          icon = MessageBoxIcon.Warning;
          caption = "Warning";
        }
      }
      _ = MessageBox.Show(Ex.Message, caption, MessageBoxButtons.OK, icon);
    }
  }
}
