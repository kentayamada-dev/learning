namespace App.Views
{
  partial class LatestView
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
      label3 = new Label();
      label4 = new Label();
      MeasuredDateTextBox = new TextBox();
      ConditionTextBox = new TextBox();
      TemperatureTextBox = new TextBox();
      SearchButton = new Button();
      ZipCodeComboBox = new ComboBox();
      EditButton = new Button();
      ListButton = new Button();
      CachedSearchCheckBox = new CheckBox();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(64, 83);
      label1.Name = "label1";
      label1.Size = new Size(111, 32);
      label1.TabIndex = 0;
      label1.Text = "Zip Code";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(64, 154);
      label2.Name = "label2";
      label2.Size = new Size(177, 32);
      label2.TabIndex = 1;
      label2.Text = "Measured Date";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(64, 225);
      label3.Name = "label3";
      label3.Size = new Size(119, 32);
      label3.TabIndex = 2;
      label3.Text = "Condition";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(64, 296);
      label4.Name = "label4";
      label4.Size = new Size(149, 32);
      label4.TabIndex = 3;
      label4.Text = "Temperature";
      // 
      // MeasuredDateTextBox
      // 
      MeasuredDateTextBox.Location = new Point(374, 154);
      MeasuredDateTextBox.Name = "MeasuredDateTextBox";
      MeasuredDateTextBox.ReadOnly = true;
      MeasuredDateTextBox.Size = new Size(355, 39);
      MeasuredDateTextBox.TabIndex = 5;
      // 
      // ConditionTextBox
      // 
      ConditionTextBox.Location = new Point(374, 225);
      ConditionTextBox.Name = "ConditionTextBox";
      ConditionTextBox.ReadOnly = true;
      ConditionTextBox.Size = new Size(355, 39);
      ConditionTextBox.TabIndex = 6;
      // 
      // TemperatureTextBox
      // 
      TemperatureTextBox.Location = new Point(374, 288);
      TemperatureTextBox.Name = "TemperatureTextBox";
      TemperatureTextBox.ReadOnly = true;
      TemperatureTextBox.Size = new Size(355, 39);
      TemperatureTextBox.TabIndex = 7;
      // 
      // SearchButton
      // 
      SearchButton.Location = new Point(64, 353);
      SearchButton.Name = "SearchButton";
      SearchButton.Size = new Size(401, 75);
      SearchButton.TabIndex = 8;
      SearchButton.Text = "Search";
      SearchButton.UseVisualStyleBackColor = true;
      SearchButton.Click += SearchButton_Click;
      // 
      // ZipCodeComboBox
      // 
      ZipCodeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      ZipCodeComboBox.FormattingEnabled = true;
      ZipCodeComboBox.Location = new Point(374, 83);
      ZipCodeComboBox.Name = "ZipCodeComboBox";
      ZipCodeComboBox.Size = new Size(355, 40);
      ZipCodeComboBox.TabIndex = 9;
      // 
      // EditButton
      // 
      EditButton.Location = new Point(579, 12);
      EditButton.Name = "EditButton";
      EditButton.Size = new Size(150, 46);
      EditButton.TabIndex = 10;
      EditButton.Text = "Edit";
      EditButton.UseVisualStyleBackColor = true;
      EditButton.Click += EditButton_Click;
      // 
      // ListButton
      // 
      ListButton.Location = new Point(374, 12);
      ListButton.Name = "ListButton";
      ListButton.Size = new Size(150, 46);
      ListButton.TabIndex = 11;
      ListButton.Text = "List";
      ListButton.UseVisualStyleBackColor = true;
      ListButton.Click += ListButton_Click;
      // 
      // CachedSearchCheckBox
      // 
      CachedSearchCheckBox.AutoSize = true;
      CachedSearchCheckBox.Checked = true;
      CachedSearchCheckBox.CheckState = CheckState.Checked;
      CachedSearchCheckBox.Location = new Point(521, 373);
      CachedSearchCheckBox.Name = "CachedSearchCheckBox";
      CachedSearchCheckBox.Size = new Size(203, 36);
      CachedSearchCheckBox.TabIndex = 12;
      CachedSearchCheckBox.Text = "Cached Search";
      CachedSearchCheckBox.UseVisualStyleBackColor = true;
      // 
      // LatestView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(CachedSearchCheckBox);
      Controls.Add(ListButton);
      Controls.Add(EditButton);
      Controls.Add(ZipCodeComboBox);
      Controls.Add(SearchButton);
      Controls.Add(TemperatureTextBox);
      Controls.Add(ConditionTextBox);
      Controls.Add(MeasuredDateTextBox);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      DoubleBuffered = false;
      Name = "LatestView";
      Text = "Latest";
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(label3, 0);
      Controls.SetChildIndex(label4, 0);
      Controls.SetChildIndex(MeasuredDateTextBox, 0);
      Controls.SetChildIndex(ConditionTextBox, 0);
      Controls.SetChildIndex(TemperatureTextBox, 0);
      Controls.SetChildIndex(SearchButton, 0);
      Controls.SetChildIndex(ZipCodeComboBox, 0);
      Controls.SetChildIndex(EditButton, 0);
      Controls.SetChildIndex(ListButton, 0);
      Controls.SetChildIndex(CachedSearchCheckBox, 0);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox MeasuredDateTextBox;
    private TextBox ConditionTextBox;
    private TextBox TemperatureTextBox;
    private Button SearchButton;
    private ComboBox ZipCodeComboBox;
    private Button EditButton;
    private Button ListButton;
    private CheckBox CachedSearchCheckBox;
  }
}