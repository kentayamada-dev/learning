namespace App.Views
{
  partial class EditView
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
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      label5 = new Label();
      StateComboBox = new ComboBox();
      MeasuredDateTimePicker = new DateTimePicker();
      ConditionComboBox = new ComboBox();
      TemperatureNumericUpDown = new NumericUpDown();
      SaveButton = new Button();
      UnitLabel = new Label();
      ((System.ComponentModel.ISupportInitialize)TemperatureNumericUpDown).BeginInit();
      SuspendLayout();
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(59, 102);
      label2.Name = "label2";
      label2.Size = new Size(67, 32);
      label2.TabIndex = 2;
      label2.Text = "State";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(59, 169);
      label3.Name = "label3";
      label3.Size = new Size(177, 32);
      label3.TabIndex = 3;
      label3.Text = "Measured Date";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(59, 236);
      label4.Name = "label4";
      label4.Size = new Size(119, 32);
      label4.TabIndex = 4;
      label4.Text = "Condition";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(59, 295);
      label5.Name = "label5";
      label5.Size = new Size(149, 32);
      label5.TabIndex = 5;
      label5.Text = "Temperature";
      // 
      // StateComboBox
      // 
      StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      StateComboBox.FormattingEnabled = true;
      StateComboBox.Location = new Point(289, 94);
      StateComboBox.Name = "StateComboBox";
      StateComboBox.Size = new Size(430, 40);
      StateComboBox.TabIndex = 6;
      // 
      // MeasuredDateTimePicker
      // 
      MeasuredDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
      MeasuredDateTimePicker.Format = DateTimePickerFormat.Custom;
      MeasuredDateTimePicker.Location = new Point(289, 161);
      MeasuredDateTimePicker.Name = "MeasuredDateTimePicker";
      MeasuredDateTimePicker.Size = new Size(430, 39);
      MeasuredDateTimePicker.TabIndex = 7;
      // 
      // ConditionComboBox
      // 
      ConditionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      ConditionComboBox.FormattingEnabled = true;
      ConditionComboBox.Location = new Point(289, 228);
      ConditionComboBox.Name = "ConditionComboBox";
      ConditionComboBox.Size = new Size(430, 40);
      ConditionComboBox.TabIndex = 8;
      // 
      // TemperatureNumericUpDown
      // 
      TemperatureNumericUpDown.DecimalPlaces = 2;
      TemperatureNumericUpDown.Location = new Point(289, 295);
      TemperatureNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
      TemperatureNumericUpDown.Name = "TemperatureNumericUpDown";
      TemperatureNumericUpDown.RightToLeft = RightToLeft.No;
      TemperatureNumericUpDown.Size = new Size(430, 39);
      TemperatureNumericUpDown.TabIndex = 9;
      TemperatureNumericUpDown.TextAlign = HorizontalAlignment.Right;
      // 
      // SaveButton
      // 
      SaveButton.Location = new Point(56, 362);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(722, 76);
      SaveButton.TabIndex = 10;
      SaveButton.Text = "Save";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // UnitLabel
      // 
      UnitLabel.AutoSize = true;
      UnitLabel.Location = new Point(725, 302);
      UnitLabel.Name = "UnitLabel";
      UnitLabel.Size = new Size(56, 32);
      UnitLabel.TabIndex = 11;
      UnitLabel.Text = "XXX";
      // 
      // EditView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(UnitLabel);
      Controls.Add(SaveButton);
      Controls.Add(TemperatureNumericUpDown);
      Controls.Add(ConditionComboBox);
      Controls.Add(MeasuredDateTimePicker);
      Controls.Add(StateComboBox);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Name = "EditView";
      Text = "Edit";
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(label3, 0);
      Controls.SetChildIndex(label4, 0);
      Controls.SetChildIndex(label5, 0);
      Controls.SetChildIndex(StateComboBox, 0);
      Controls.SetChildIndex(MeasuredDateTimePicker, 0);
      Controls.SetChildIndex(ConditionComboBox, 0);
      Controls.SetChildIndex(TemperatureNumericUpDown, 0);
      Controls.SetChildIndex(SaveButton, 0);
      Controls.SetChildIndex(UnitLabel, 0);
      ((System.ComponentModel.ISupportInitialize)TemperatureNumericUpDown).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private ComboBox StateComboBox;
    private DateTimePicker MeasuredDateTimePicker;
    private ComboBox ConditionComboBox;
    private NumericUpDown TemperatureNumericUpDown;
    private Button SaveButton;
    private Label UnitLabel;
  }
}