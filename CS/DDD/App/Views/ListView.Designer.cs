namespace App.Views
{
  partial class ListView
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
      WeathersDataGridView = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)WeathersDataGridView).BeginInit();
      SuspendLayout();
      // 
      // WeathersDataGridView
      // 
      WeathersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      WeathersDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
      WeathersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      WeathersDataGridView.Dock = DockStyle.Bottom;
      WeathersDataGridView.Location = new Point(0, 60);
      WeathersDataGridView.Name = "WeathersDataGridView";
      WeathersDataGridView.RowHeadersWidth = 82;
      WeathersDataGridView.RowTemplate.Height = 41;
      WeathersDataGridView.Size = new Size(1310, 433);
      WeathersDataGridView.TabIndex = 0;
      // 
      // ListView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1310, 493);
      Controls.Add(WeathersDataGridView);
      Name = "ListView";
      Text = "List";
      Controls.SetChildIndex(WeathersDataGridView, 0);
      ((System.ComponentModel.ISupportInitialize)WeathersDataGridView).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private DataGridView WeathersDataGridView;
  }
}