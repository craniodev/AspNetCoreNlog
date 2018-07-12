using NLog;
using System;

namespace ConsoleNLog
{
    class Program
    {
        public static void Main(string[] args)
        {
            GlobalDiagnosticsContext.Set("configDir", "C:\\Users\\rafae\\source\\repos\\AspNetCoreNlog\\src\\ConsoleNLog\\Logs");

            var logger = NLog.Web.NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();

            logger.Debug("console logging is great");
            logger.Info("console logging is great");
            logger.Warn("console logging is great");
            logger.Error("console logging is great");
            logger.Fatal("console logging is great");

            Console.WriteLine("log sent");
            Console.ReadKey();
        }
    }
}
