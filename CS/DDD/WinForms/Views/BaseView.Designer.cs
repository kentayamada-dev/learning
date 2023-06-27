namespace WinForms.Views
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
      NameLabel = new Label();
      NameValueLabel = new Label();
      SuspendLayout();
      // 
      // NameLabel
      // 
      NameLabel.AutoSize = true;
      NameLabel.Location = new Point(12, 9);
      NameLabel.Name = "NameLabel";
      NameLabel.Size = new Size(90, 32);
      NameLabel.TabIndex = 0;
      NameLabel.Text = "Name: ";
      NameLabel.Visible = false;
      // 
      // NameValueLabel
      // 
      NameValueLabel.AutoSize = true;
      NameValueLabel.Location = new Point(108, 9);
      NameValueLabel.Name = "NameValueLabel";
      NameValueLabel.Size = new Size(78, 32);
      NameValueLabel.TabIndex = 1;
      NameValueLabel.Text = "label1";
      NameValueLabel.Visible = false;
      // 
      // BaseView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(974, 629);
      Controls.Add(NameValueLabel);
      Controls.Add(NameLabel);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "BaseView";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "BaseView";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label NameLabel;
    private Label NameValueLabel;
  }
}