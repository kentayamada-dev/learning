namespace WinForms.Views
{
  partial class WeatherEditorView
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
      StateComboBox = new ComboBox();
      MeasuredDateDateTimePicker = new DateTimePicker();
      ConditionComboBox = new ComboBox();
      TemperatureNumericUpDown = new NumericUpDown();
      SaveButton = new Button();
      UnitLabel = new Label();
      ((System.ComponentModel.ISupportInitialize)TemperatureNumericUpDown).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(68, 123);
      label1.Name = "label1";
      label1.Size = new Size(67, 32);
      label1.TabIndex = 2;
      label1.Text = "State";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(68, 219);
      label2.Name = "label2";
      label2.Size = new Size(177, 32);
      label2.TabIndex = 3;
      label2.Text = "Measured Date";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(68, 315);
      label3.Name = "label3";
      label3.Size = new Size(119, 32);
      label3.TabIndex = 4;
      label3.Text = "Condition";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(68, 411);
      label4.Name = "label4";
      label4.Size = new Size(149, 32);
      label4.TabIndex = 5;
      label4.Text = "Temperature";
      // 
      // StateComboBox
      // 
      StateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      StateComboBox.FormattingEnabled = true;
      StateComboBox.Location = new Point(420, 123);
      StateComboBox.Name = "StateComboBox";
      StateComboBox.Size = new Size(400, 40);
      StateComboBox.TabIndex = 6;
      // 
      // MeasuredDateDateTimePicker
      // 
      MeasuredDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
      MeasuredDateDateTimePicker.Format = DateTimePickerFormat.Custom;
      MeasuredDateDateTimePicker.Location = new Point(420, 219);
      MeasuredDateDateTimePicker.Name = "MeasuredDateDateTimePicker";
      MeasuredDateDateTimePicker.Size = new Size(400, 39);
      MeasuredDateDateTimePicker.TabIndex = 7;
      // 
      // ConditionComboBox
      // 
      ConditionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
      ConditionComboBox.FormattingEnabled = true;
      ConditionComboBox.Location = new Point(420, 315);
      ConditionComboBox.Name = "ConditionComboBox";
      ConditionComboBox.Size = new Size(400, 40);
      ConditionComboBox.TabIndex = 8;
      // 
      // TemperatureNumericUpDown
      // 
      TemperatureNumericUpDown.DecimalPlaces = 2;
      TemperatureNumericUpDown.Location = new Point(420, 411);
      TemperatureNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
      TemperatureNumericUpDown.Name = "TemperatureNumericUpDown";
      TemperatureNumericUpDown.Size = new Size(400, 39);
      TemperatureNumericUpDown.TabIndex = 9;
      // 
      // SaveButton
      // 
      SaveButton.Location = new Point(68, 494);
      SaveButton.Name = "SaveButton";
      SaveButton.Size = new Size(752, 78);
      SaveButton.TabIndex = 10;
      SaveButton.Text = "Save";
      SaveButton.UseVisualStyleBackColor = true;
      SaveButton.Click += SaveButton_Click;
      // 
      // UnitLabel
      // 
      UnitLabel.AutoSize = true;
      UnitLabel.Location = new Point(826, 413);
      UnitLabel.Name = "UnitLabel";
      UnitLabel.Size = new Size(78, 32);
      UnitLabel.TabIndex = 11;
      UnitLabel.Text = "label5";
      // 
      // WeatherEditorView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(1000, 600);
      Controls.Add(UnitLabel);
      Controls.Add(SaveButton);
      Controls.Add(TemperatureNumericUpDown);
      Controls.Add(ConditionComboBox);
      Controls.Add(MeasuredDateDateTimePicker);
      Controls.Add(StateComboBox);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "WeatherEditorView";
      Text = "Weather Editor";
      Controls.SetChildIndex(label1, 0);
      Controls.SetChildIndex(label2, 0);
      Controls.SetChildIndex(label3, 0);
      Controls.SetChildIndex(label4, 0);
      Controls.SetChildIndex(StateComboBox, 0);
      Controls.SetChildIndex(MeasuredDateDateTimePicker, 0);
      Controls.SetChildIndex(ConditionComboBox, 0);
      Controls.SetChildIndex(TemperatureNumericUpDown, 0);
      Controls.SetChildIndex(SaveButton, 0);
      Controls.SetChildIndex(UnitLabel, 0);
      ((System.ComponentModel.ISupportInitialize)TemperatureNumericUpDown).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private ComboBox StateComboBox;
    private DateTimePicker MeasuredDateDateTimePicker;
    private ComboBox ConditionComboBox;
    private NumericUpDown TemperatureNumericUpDown;
    private Button SaveButton;
    private Label UnitLabel;
  }
}