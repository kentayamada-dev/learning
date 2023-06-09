﻿namespace WinForms.Views
{
  partial class LatestWeatherView
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
      components = new System.ComponentModel.Container();
      ListButton = new Button();
      EditButton = new Button();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      ZipCodeComboBox = new ComboBox();
      MeasuredDateTextBox = new TextBox();
      ConditionTextBox = new TextBox();
      TemperatureTextBox = new TextBox();
      SearchButton = new Button();
      CachedSearchCheckBox = new CheckBox();
      CachedSearchTimer = new System.Windows.Forms.Timer(components);
      CachedSearchProgressBar = new ProgressBar();
      SuspendLayout();
      // 
      // ListButton
      // 
      ListButton.Location = new Point(501, 21);
      ListButton.Name = "ListButton";
      ListButton.Size = new Size(150, 46);
      ListButton.TabIndex = 2;
      ListButton.Text = "List";
      ListButton.UseVisualStyleBackColor = true;
      ListButton.Click += ListButton_Click;
      // 
      // EditButton
      // 
      EditButton.Location = new Point(730, 21);
      EditButton.Name = "EditButton";
      EditButton.Size = new Size(150, 46);
      EditButton.TabIndex = 3;
      EditButton.Text = "Edit";
      EditButton.UseVisualStyleBackColor = true;
      EditButton.Click += EditButton_Click;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(66, 120);
      label1.Name = "label1";
      label1.Size = new Size(111, 32);
      label1.TabIndex = 4;
      label1.Text = "Zip Code";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(66, 218);
      label2.Name = "label2";
      label2.Size = new Size(177, 32);
      label2.TabIndex = 5;
      label2.Text = "Measured Date";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(66, 316);
      label3.Name = "label3";
      label3.Size = new Size(119, 32);
      label3.TabIndex = 6;
      label3.Text = "Condition";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(66, 414);
      label4.Name = "label4";
      label4.Size = new Size(149, 32);
      label4.TabIndex = 7;
      label4.Text = "Temperature";
      // 
      // ZipCodeComboBox
      // 
      ZipCodeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      ZipCodeComboBox.FormattingEnabled = true;
      ZipCodeComboBox.Location = new Point(501, 112);
      ZipCodeComboBox.Name = "ZipCodeComboBox";
      ZipCodeComboBox.Size = new Size(379, 40);
      ZipCodeComboBox.TabIndex = 8;
      // 
      // MeasuredDateTextBox
      // 
      MeasuredDateTextBox.Location = new Point(501, 211);
      MeasuredDateTextBox.Name = "MeasuredDateTextBox";
      MeasuredDateTextBox.ReadOnly = true;
      MeasuredDateTextBox.Size = new Size(379, 39);
      MeasuredDateTextBox.TabIndex = 9;
      // 
      // ConditionTextBox
      // 
      ConditionTextBox.Location = new Point(501, 309);
      ConditionTextBox.Name = "ConditionTextBox";
      ConditionTextBox.ReadOnly = true;
      ConditionTextBox.Size = new Size(379, 39);
      ConditionTextBox.TabIndex = 10;
      // 
      // TemperatureTextBox
      // 
      TemperatureTextBox.Location = new Point(501, 407);
      TemperatureTextBox.Name = "TemperatureTextBox";
      TemperatureTextBox.ReadOnly = true;
      TemperatureTextBox.Size = new Size(379, 39);
      TemperatureTextBox.TabIndex = 11;
      // 
      // SearchButton
      // 
      SearchButton.Location = new Point(66, 491);
      SearchButton.Name = "SearchButton";
      SearchButton.Size = new Size(497, 97);
      SearchButton.TabIndex = 12;
      SearchButton.Text = "Search";
      SearchButton.UseVisualStyleBackColor = true;
      SearchButton.Click += SearchButton_Click;
      // 
      // CachedSearchCheckBox
      // 
      CachedSearchCheckBox.AutoSize = true;
      CachedSearchCheckBox.Location = new Point(633, 491);
      CachedSearchCheckBox.Name = "CachedSearchCheckBox";
      CachedSearchCheckBox.Size = new Size(203, 36);
      CachedSearchCheckBox.TabIndex = 13;
      CachedSearchCheckBox.Text = "Cached Search";
      CachedSearchCheckBox.UseVisualStyleBackColor = true;
      CachedSearchCheckBox.CheckedChanged += CachedSearchCheckBox_Click;
      // 
      // CachedSearchTimer
      // 
      CachedSearchTimer.Enabled = true;
      CachedSearchTimer.Interval = 1000;
      CachedSearchTimer.Tick += CachedSearchTimer_Tick;
      // 
      // CachedSearchProgressBar
      // 
      CachedSearchProgressBar.Location = new Point(581, 542);
      CachedSearchProgressBar.Name = "CachedSearchProgressBar";
      CachedSearchProgressBar.Size = new Size(299, 46);
      CachedSearchProgressBar.Style = ProgressBarStyle.Continuous;
      CachedSearchProgressBar.TabIndex = 14;
      // 
      // LatestWeatherView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(1000, 600);
      Controls.Add(CachedSearchProgressBar);
      Controls.Add(CachedSearchCheckBox);
      Controls.Add(SearchButton);
      Controls.Add(TemperatureTextBox);
      Controls.Add(ConditionTextBox);
      Controls.Add(MeasuredDateTextBox);
      Controls.Add(ZipCodeComboBox);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(EditButton);
      Controls.Add(ListButton);
      Name = "LatestWeatherView";
      Text = "Latest Weather";
      Controls.SetChildIndex(ListButton, 0);
      Controls.SetChildIndex(EditButton, 0);
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(label3, 0);
      Controls.SetChildIndex(label4, 0);
      Controls.SetChildIndex(ZipCodeComboBox, 0);
      Controls.SetChildIndex(MeasuredDateTextBox, 0);
      Controls.SetChildIndex(ConditionTextBox, 0);
      Controls.SetChildIndex(TemperatureTextBox, 0);
      Controls.SetChildIndex(SearchButton, 0);
      Controls.SetChildIndex(CachedSearchCheckBox, 0);
      Controls.SetChildIndex(CachedSearchProgressBar, 0);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button ListButton;
    private Button EditButton;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private ComboBox ZipCodeComboBox;
    private TextBox MeasuredDateTextBox;
    private TextBox ConditionTextBox;
    private TextBox TemperatureTextBox;
    private Button SearchButton;
    private CheckBox CachedSearchCheckBox;
    private System.Windows.Forms.Timer CachedSearchTimer;
    private ProgressBar CachedSearchProgressBar;
  }
}