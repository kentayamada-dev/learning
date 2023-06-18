﻿using App.BackgroundWorkers;
using App.Views;
using Domain;

namespace App;

internal static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  private static void Main()
  {
    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    ApplicationConfiguration.Initialize();

    WeathersCachingWorker.Start();

    if (Shared.IsFake || Shared.IsDebugMode)
    {
      Application.Run(new InfoView());
    }
    else
    {
      Application.Run(new LoginView());
    }
  }
}
