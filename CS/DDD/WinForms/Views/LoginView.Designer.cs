namespace WinForms.Views
{
  partial class LoginView
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
      label2 = new Label();
      NameTextBox = new TextBox();
      PasswordTextBox = new TextBox();
      LoginButton = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(207, 125);
      label1.Name = "label1";
      label1.Size = new Size(78, 32);
      label1.TabIndex = 0;
      label1.Text = "Name";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(207, 301);
      label2.Name = "label2";
      label2.Size = new Size(111, 32);
      label2.TabIndex = 1;
      label2.Text = "Password";
      // 
      // NameTextBox
      // 
      NameTextBox.Location = new Point(397, 125);
      NameTextBox.Name = "NameTextBox";
      NameTextBox.Size = new Size(320, 39);
      NameTextBox.TabIndex = 2;
      // 
      // PasswordTextBox
      // 
      PasswordTextBox.Location = new Point(397, 301);
      PasswordTextBox.Name = "PasswordTextBox";
      PasswordTextBox.Size = new Size(320, 39);
      PasswordTextBox.TabIndex = 3;
      // 
      // LoginButton
      // 
      LoginButton.Location = new Point(207, 468);
      LoginButton.Name = "LoginButton";
      LoginButton.Size = new Size(510, 116);
      LoginButton.TabIndex = 4;
      LoginButton.Text = "Login";
      LoginButton.UseVisualStyleBackColor = true;
      // 
      // LoginView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(974, 629);
      Controls.Add(LoginButton);
      Controls.Add(PasswordTextBox);
      Controls.Add(NameTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "LoginView";
      Text = "Login";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox NameTextBox;
    private TextBox PasswordTextBox;
    private Button LoginButton;
  }
}