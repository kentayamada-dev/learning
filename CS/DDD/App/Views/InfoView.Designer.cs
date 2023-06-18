namespace App.Views
{
  partial class InfoView
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
      CloseButton = new Button();
      SuspendLayout();
      // 
      // DebugModeCheckBox
      // 
      DebugModeCheckBox.AutoCheck = false;
      DebugModeCheckBox.AutoSize = true;
      DebugModeCheckBox.Location = new Point(121, 92);
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
      FakeDataModeCheckBox.Location = new Point(440, 92);
      FakeDataModeCheckBox.Name = "FakeDataModeCheckBox";
      FakeDataModeCheckBox.Size = new Size(220, 36);
      FakeDataModeCheckBox.TabIndex = 1;
      FakeDataModeCheckBox.Text = "Fake Data Mode";
      FakeDataModeCheckBox.UseVisualStyleBackColor = true;
      // 
      // ProceedButton
      // 
      ProceedButton.Location = new Point(59, 328);
      ProceedButton.Name = "ProceedButton";
      ProceedButton.Size = new Size(250, 98);
      ProceedButton.TabIndex = 2;
      ProceedButton.Text = "Proceed";
      ProceedButton.UseVisualStyleBackColor = true;
      ProceedButton.Click += ProceedButton_Click;
      // 
      // CloseButton
      // 
      CloseButton.Location = new Point(449, 328);
      CloseButton.Name = "CloseButton";
      CloseButton.Size = new Size(250, 98);
      CloseButton.TabIndex = 3;
      CloseButton.Text = "Close";
      CloseButton.UseVisualStyleBackColor = true;
      CloseButton.Click += CloseButton_Click;
      // 
      // InfoView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(CloseButton);
      Controls.Add(ProceedButton);
      Controls.Add(FakeDataModeCheckBox);
      Controls.Add(DebugModeCheckBox);
      Name = "InfoView";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Info";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private CheckBox DebugModeCheckBox;
    private CheckBox FakeDataModeCheckBox;
    private Button ProceedButton;
    private Button CloseButton;
  }
}