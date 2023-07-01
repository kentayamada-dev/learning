namespace WinForms.Views
{
  partial class WeatherListView
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
      tableLayoutPanel1 = new TableLayoutPanel();
      WeathersListGridView = new DataGridView();
      tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)WeathersListGridView).BeginInit();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
      tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
      tableLayoutPanel1.Controls.Add(WeathersListGridView, 0, 0);
      tableLayoutPanel1.Dock = DockStyle.Bottom;
      tableLayoutPanel1.Location = new Point(0, 85);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 1;
      tableLayoutPanel1.RowStyles.Add(new RowStyle());
      tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      tableLayoutPanel1.Size = new Size(1000, 515);
      tableLayoutPanel1.TabIndex = 2;
      // 
      // WeathersListGridView
      // 
      WeathersListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      WeathersListGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      WeathersListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      WeathersListGridView.Dock = DockStyle.Fill;
      WeathersListGridView.Location = new Point(3, 3);
      WeathersListGridView.Name = "WeathersListGridView";
      WeathersListGridView.RowHeadersWidth = 82;
      WeathersListGridView.RowTemplate.Height = 41;
      WeathersListGridView.Size = new Size(994, 509);
      WeathersListGridView.TabIndex = 0;
      // 
      // WeatherListView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(1500, 600);
      Controls.Add(tableLayoutPanel1);
      Name = "WeatherListView";
      Text = "Weather List";
      Controls.SetChildIndex(tableLayoutPanel1, 0);
      tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)WeathersListGridView).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private DataGridView WeathersListGridView;
  }
}