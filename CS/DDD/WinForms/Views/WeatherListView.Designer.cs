﻿namespace WinForms.Views
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
      SuspendLayout();
      // 
      // WeatherListView
      // 
      AutoScaleDimensions = new SizeF(13F, 32F);
      ClientSize = new Size(974, 629);
      Name = "WeatherListView";
      Text = "Weather List";
      ResumeLayout(false);
    }

    #endregion
  }
}