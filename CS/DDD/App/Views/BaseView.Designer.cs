namespace App.Views
{
  partial class BaseView
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      LoginIDLabel = new Label();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(12, 9);
      label1.Name = "label1";
      label1.Size = new Size(101, 32);
      label1.TabIndex = 0;
      label1.Text = "LoginID:";
      // 
      // LoginIDLabel
      // 
      LoginIDLabel.AutoSize = true;
      LoginIDLabel.Location = new Point(119, 9);
      LoginIDLabel.Name = "LoginIDLabel";
      LoginIDLabel.Size = new Size(84, 32);
      LoginIDLabel.TabIndex = 1;
      LoginIDLabel.Text = "XXXXX";
      // 
      // BaseView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LoginIDLabel);
      Controls.Add(label1);
      DoubleBuffered = true;
      MaximizeBox = false;
      Name = "BaseView";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Base";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label LoginIDLabel;
  }
}