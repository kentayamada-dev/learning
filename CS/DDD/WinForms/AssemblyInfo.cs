using System.Runtime.InteropServices;

[assembly: ComVisible(false)]
[assembly: Guid("d1123efe-16f7-4f12-9628-69ead25cdc3d")]

// Configure log4net
[assembly: log4net.Config.XmlConfigurator(ConfigFile = @"Log4net.config", Watch = true)]
