namespace WinForms.Views
{
  partial class SigninView
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
      SigninButton = new Button();
      SignupButton = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(108, 144);
      label1.Name = "label1";
      label1.Size = new Size(78, 32);
      label1.TabIndex = 0;
      label1.Text = "Name";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(108, 261);
      label2.Name = "label2";
      label2.Size = new Size(111, 32);
      label2.TabIndex = 1;
      label2.Text = "Password";
      // 
      // NameTextBox
      // 
      NameTextBox.Location = new Point(334, 144);
      NameTextBox.Name = "NameTextBox";
      NameTextBox.Size = new Size(541, 39);
      NameTextBox.TabIndex = 2;
      // 
      // PasswordTextBox
      // 
      PasswordTextBox.Location = new Point(334, 261);
      PasswordTextBox.Name = "PasswordTextBox";
      PasswordTextBox.PasswordChar = '*';
      PasswordTextBox.Size = new Size(541, 39);
      PasswordTextBox.TabIndex = 3;
      // 
      // SigninButton
      // 
      SigninButton.Location = new Point(108, 381);
      SigninButton.Name = "SigninButton";
      SigninButton.Size = new Size(767, 116);
      SigninButton.TabIndex = 4;
      SigninButton.Text = "SIGN IN";
      SigninButton.UseVisualStyleBackColor = true;
      SigninButton.Click += SigninButton_Click;
      // 
      // SignupButton
      // 
      SignupButton.Location = new Point(610, 515);
      SignupButton.Name = "SignupButton";
      SignupButton.Size = new Size(265, 45);
      SignupButton.TabIndex = 5;
      SignupButton.Text = "Sign Up?";
      SignupButton.UseVisualStyleBackColor = true;
      SignupButton.Click += SignupButton_Click;
      // 
      // SigninView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(1000, 600);
      Controls.Add(SignupButton);
      Controls.Add(SigninButton);
      Controls.Add(PasswordTextBox);
      Controls.Add(NameTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "SigninView";
      Text = "Signin";
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(NameTextBox, 0);
      Controls.SetChildIndex(PasswordTextBox, 0);
      Controls.SetChildIndex(SigninButton, 0);
      Controls.SetChildIndex(SignupButton, 0);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox NameTextBox;
    private TextBox PasswordTextBox;
    private Button SigninButton;
    private Button SignupButton;
  }
}