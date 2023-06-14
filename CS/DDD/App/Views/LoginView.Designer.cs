namespace App.Views
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
      LoginIDTextBox = new TextBox();
      PasswordTextBox = new TextBox();
      LoginButton = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(123, 87);
      label1.Name = "label1";
      label1.Size = new Size(103, 32);
      label1.TabIndex = 0;
      label1.Text = "Login ID";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(123, 237);
      label2.Name = "label2";
      label2.Size = new Size(111, 32);
      label2.TabIndex = 1;
      label2.Text = "Password";
      // 
      // LoginIDTextBox
      // 
      LoginIDTextBox.Location = new Point(291, 87);
      LoginIDTextBox.Name = "LoginIDTextBox";
      LoginIDTextBox.Size = new Size(379, 39);
      LoginIDTextBox.TabIndex = 2;
      // 
      // PasswordTextBox
      // 
      PasswordTextBox.Location = new Point(291, 237);
      PasswordTextBox.Name = "PasswordTextBox";
      PasswordTextBox.PasswordChar = '*';
      PasswordTextBox.Size = new Size(379, 39);
      PasswordTextBox.TabIndex = 3;
      // 
      // LoginButton
      // 
      LoginButton.Location = new Point(73, 341);
      LoginButton.Name = "LoginButton";
      LoginButton.Size = new Size(673, 97);
      LoginButton.TabIndex = 4;
      LoginButton.Text = "Login";
      LoginButton.UseVisualStyleBackColor = true;
      LoginButton.Click += LoginButton_Click;
      // 
      // LoginView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LoginButton);
      Controls.Add(PasswordTextBox);
      Controls.Add(LoginIDTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      DoubleBuffered = false;
      Name = "LoginView";
      Text = "Login";
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(LoginIDTextBox, 0);
      Controls.SetChildIndex(PasswordTextBox, 0);
      Controls.SetChildIndex(LoginButton, 0);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox LoginIDTextBox;
    private TextBox PasswordTextBox;
    private Button LoginButton;
  }
}