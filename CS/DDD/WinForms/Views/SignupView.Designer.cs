namespace WinForms.Views
{
  partial class SignupView
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
      SignupButton = new Button();
      PasswordTextBox = new TextBox();
      NameTextBox = new TextBox();
      label2 = new Label();
      label1 = new Label();
      SuspendLayout();
      // 
      // SignupButton
      // 
      SignupButton.Location = new Point(108, 388);
      SignupButton.Name = "SignupButton";
      SignupButton.Size = new Size(767, 116);
      SignupButton.TabIndex = 9;
      SignupButton.Text = "SIGN UP";
      SignupButton.UseVisualStyleBackColor = true;
      SignupButton.Click += SignupButton_Click;
      // 
      // PasswordTextBox
      // 
      PasswordTextBox.Location = new Point(334, 268);
      PasswordTextBox.Name = "PasswordTextBox";
      PasswordTextBox.PasswordChar = '*';
      PasswordTextBox.Size = new Size(541, 39);
      PasswordTextBox.TabIndex = 8;
      // 
      // NameTextBox
      // 
      NameTextBox.Location = new Point(334, 151);
      NameTextBox.Name = "NameTextBox";
      NameTextBox.Size = new Size(541, 39);
      NameTextBox.TabIndex = 7;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(108, 268);
      label2.Name = "label2";
      label2.Size = new Size(111, 32);
      label2.TabIndex = 6;
      label2.Text = "Password";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(108, 151);
      label1.Name = "label1";
      label1.Size = new Size(78, 32);
      label1.TabIndex = 5;
      label1.Text = "Name";
      // 
      // SignupView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(1000, 600);
      Controls.Add(SignupButton);
      Controls.Add(PasswordTextBox);
      Controls.Add(NameTextBox);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "SignupView";
      Text = "Signup";
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(NameTextBox, 0);
      Controls.SetChildIndex(PasswordTextBox, 0);
      Controls.SetChildIndex(SignupButton, 0);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button SignupButton;
    private TextBox PasswordTextBox;
    private TextBox NameTextBox;
    private Label label2;
    private Label label1;
  }
}