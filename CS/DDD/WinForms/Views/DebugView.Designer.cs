namespace WinForms.Views
{
  partial class DebugView
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
      DebugModeCheckBox = new CheckBox();
      FakeDataModeCheckBox = new CheckBox();
      ProceedButton = new Button();
      ExitButton = new Button();
      SuspendLayout();
      // 
      // DebugModeCheckBox
      // 
      DebugModeCheckBox.AutoCheck = false;
      DebugModeCheckBox.AutoSize = true;
      DebugModeCheckBox.Location = new Point(154, 68);
      DebugModeCheckBox.Name = "DebugModeCheckBox";
      DebugModeCheckBox.Size = new Size(188, 36);
      DebugModeCheckBox.TabIndex = 0;
      DebugModeCheckBox.Text = "Debug Mode";
      DebugModeCheckBox.UseVisualStyleBackColor = true;
      // 
      // FakeDataModeCheckBox
      // 
      FakeDataModeCheckBox.AutoCheck = false;
      FakeDataModeCheckBox.AutoSize = true;
      FakeDataModeCheckBox.Location = new Point(388, 68);
      FakeDataModeCheckBox.Name = "FakeDataModeCheckBox";
      FakeDataModeCheckBox.Size = new Size(220, 36);
      FakeDataModeCheckBox.TabIndex = 1;
      FakeDataModeCheckBox.Text = "Fake Data Mode";
      FakeDataModeCheckBox.UseVisualStyleBackColor = true;
      // 
      // ProceedButton
      // 
      ProceedButton.Location = new Point(35, 184);
      ProceedButton.Name = "ProceedButton";
      ProceedButton.Size = new Size(307, 191);
      ProceedButton.TabIndex = 2;
      ProceedButton.Text = "Proceed";
      ProceedButton.UseVisualStyleBackColor = true;
      ProceedButton.Click += ProceedButton_Click;
      // 
      // ExitButton
      // 
      ExitButton.Location = new Point(388, 184);
      ExitButton.Name = "ExitButton";
      ExitButton.Size = new Size(307, 191);
      ExitButton.TabIndex = 3;
      ExitButton.Text = "Exit";
      ExitButton.UseVisualStyleBackColor = true;
      ExitButton.Click += ExitButton_Click;
      // 
      // DebugView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(730, 399);
      Controls.Add(ExitButton);
      Controls.Add(ProceedButton);
      Controls.Add(FakeDataModeCheckBox);
      Controls.Add(DebugModeCheckBox);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      MaximizeBox = false;
      Name = "DebugView";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Debug";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private CheckBox DebugModeCheckBox;
    private CheckBox FakeDataModeCheckBox;
    private Button ProceedButton;
    private Button ExitButton;
  }
}